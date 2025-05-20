using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    Transform t;
    float a;
    float b;
    float tt;
    Vector3 j;

    void Start()
    {
        t = GetComponent<Transform>();
        a = Random.Range(1f, 1.5f);
        b = Random.Range(0.0f, 1.0f);
        tt = Time.time;
        j = t.localPosition;
    }

    void Update()
    {
        transform.localScale = new Vector3(Mathf.Abs(Mathf.Cos(a * (Time.time - tt) + b)), j.y, 0.025f);
    }
}
