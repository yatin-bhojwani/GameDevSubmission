using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioManage : MonoBehaviour
{
    [SerializeField] AudioSource SFXSource;

    public AudioClip jump;
    public AudioClip gem;

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);    
    }
}
