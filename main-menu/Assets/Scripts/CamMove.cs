using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour
{
    public Transform player;
    public float x;
    public float y;
    public float z;

    void Update()
    {
        transform.position = new Vector3(player.position.x + x, player.position.y + y, player.position.z + z); 
    }
}
