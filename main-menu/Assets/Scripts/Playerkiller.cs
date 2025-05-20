using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerkiller : MonoBehaviour
{
    public Transform playe;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(0f, -10f, playe.position.z);
    }
}
