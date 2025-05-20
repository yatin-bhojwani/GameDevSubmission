using System.ComponentModel.Design.Serialization;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreTracker;
    public TextMeshProUGUI highScoreText;

    public float scoreMultiplier;
    public Ded d;
    float t;
    public int score;
    public int highScore;

    public int increase;
    int f = 0;
    
    bool g;
    bool a;

    void Start()
    {
        highScore = PlayerPrefs.GetInt("High Score", 0);
        highScoreText.gameObject.SetActive(false);

        g = true;
        a = true;

        t = Time.time;
    }

    public void Scor()
    {
        f++;
    }

    void Update()
    {
        if (!d.isObstacle && a)
        {
            score = Mathf.FloorToInt((Time.time - t) * scoreMultiplier) + f*increase;
            scoreTracker.text = score.ToString();
        }
        if(d.isObstacle && g)
        {
            score = Mathf.FloorToInt((Time.time - t) * scoreMultiplier) + f*increase;
            g = false;
            scoreTracker.text = score.ToString();

            if(score > highScore)
            {
                highScore = score;
                PlayerPrefs.SetInt("High Score", highScore);

                highScoreText.gameObject.SetActive(true);
                highScoreText.text = "New High Score  " + highScore + " !!!";

            }
        }
    }
}
