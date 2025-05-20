using UnityEngine;

public class GemGenerator : MonoBehaviour
{
    public GameObject g;

    void Awake()
    {
        int i = Mathf.FloorToInt(Random.Range(0f, 5f));

        if(i == 1)
        {
            g.SetActive(true);
        }

        else
        {
            g.SetActive(false);

            print(i);
        }
    }
}
