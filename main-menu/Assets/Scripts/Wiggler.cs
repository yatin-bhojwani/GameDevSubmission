using UnityEngine;

public class Wiggler : MonoBehaviour
{
    private Vector3 v;

    [SerializeField] float o;
    [SerializeField] float d;

    void Start()
    {
        v = transform.position;

        o = Random.Range(0.5f, 2f);
        d = Random.Range(0f, Mathf.PI);
    }

    void Update()
    {
        transform.position = new Vector3(10 * Mathf.Cos(o * Time.time + d), v.y, v.z);
    }
}
