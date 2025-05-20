using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPlayer : MonoBehaviour
{
    public void Resett()
    {
        PlayerPrefs.DeleteAll();
    }
}
