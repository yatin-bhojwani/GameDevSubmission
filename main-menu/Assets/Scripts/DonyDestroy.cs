using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DonyDestroy : MonoBehaviour
{
    GameObject music;

    void Awake()
    {
        music = GameObject.FindGameObjectWithTag("Music");

        DontDestroyOnLoad(music);
    }
}
