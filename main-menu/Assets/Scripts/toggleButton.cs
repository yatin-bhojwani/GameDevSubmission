using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class toggleButton : MonoBehaviour
{
    [SerializeField] GameObject[] colours;
    public int i;
    int arrayLength;
    public Material playerM;
    
    public void SaveData()
    {
        PlayerPrefs.SetInt("colourIndex", i);

    }
    public void Start()
    {
        i = PlayerPrefs.GetInt("colourIndex", 0);
        
        
        arrayLength = colours.Length;
    }

   
    public void IncreaseIndex()
    {
        i++;
        if ( i > arrayLength - 1)
        {
            i = 0;
        }
        SaveData();
        Changer();
    }

    public void DecreaseIndex()
    {
        i--;
        if (i < 0)
        {
            i = arrayLength - 1;
        }
        SaveData();
        Changer();
    }

    /*
    public void ChangeActivness()
    {
        foreach(GameObject g in colours )
        {
            g.SetActive(false);
        }

        colours[i].SetActive(true);
    }
    */

    void Changer()
    {
        if( i == 0)
        {
            playerM.color = Color.red;
        }

        else if( i == 1)
        {
            playerM.color = Color.yellow;
        }

        else if (i == 2)
        {
            playerM.color = Color.green;
        }

        else if (i == 3)
        {
            playerM.color = Color.cyan;
        }

        else if (i == 4)
        {
            playerM.color = Color.magenta;
        }
    }
}


