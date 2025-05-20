using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class HighScore : MonoBehaviour
{
    public TextMeshProUGUI scoreDisplay;
    Score hS;

    int g;

    private void Start()
    {
        g = PlayerPrefs.GetInt("High Score", 0);

        scoreDisplay.text = "High Score: " + g;
    }
}
