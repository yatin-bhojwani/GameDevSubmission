using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEff : MonoBehaviour
{
    void Start()
    {
        Invoke("Des", 3f);
    }

    private void Des()
    {
        Destroy(gameObject);
    }
}
