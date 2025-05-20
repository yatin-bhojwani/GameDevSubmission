using UnityEngine;

public class Destoryer : MonoBehaviour
{
    public LayerMask obstacle;

    private void FixedUpdate()
    {
        Collider[] col = Physics.OverlapBox(transform.position, new Vector3(50f, 50f, 0.5f), Quaternion.identity, obstacle);  

        foreach (Collider c in col)
        {
            GameObject g = c.gameObject;

            if (g != null)
            {
                Destroy(g);
            }
        }
    }
}
