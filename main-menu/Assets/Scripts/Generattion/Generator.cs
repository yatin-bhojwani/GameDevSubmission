using UnityEngine;

public class Generator : MonoBehaviour
{
    float t;
    [SerializeField] float threshold;
    private bool readyToGenetarate = true;
    public GameObject[] Obstacle;
    float l;

    private void Start()
    {
        l = Obstacle.Length;
    }

    void FixedUpdate()
    {
        t = transform.position.z / 40f;

        if (Mathf.Abs(Mathf.Floor(t) +1 -t) < threshold && readyToGenetarate)
        {
            readyToGenetarate = false;

            float z = Mathf.Round(transform.position.z);

            Instantiate(Obstacle[Mathf.FloorToInt(Random.Range(0, l))], new Vector3(0f , 0f, z), Quaternion.identity);

            Invoke("ResetGeneration", 0.3f);
        }
    }

    void ResetGeneration()
    {
        readyToGenetarate = true;
    }
}