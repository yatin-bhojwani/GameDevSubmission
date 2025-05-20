using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Ded : MonoBehaviour
{
    public bool isObstacle;
    private Movement m;

    public PostProcessLayer p;
    public Button restart;
    public Button mainMenu;

    public LayerMask dedLayer;
    public LayerMask post;

    private bool j;

    private void Start()
    {
        m = GetComponent<Movement>();

        p.volumeLayer = post;

        restart.gameObject.SetActive(false);
        mainMenu.gameObject.SetActive(false);

        j = false;
    }

    private void OnCollisionEnter(Collision c)
    {
        if(c.collider.CompareTag("Obstacle") && !j)
        {
            isObstacle = true;
            j = true;
        }

        if (isObstacle)
        {
            m.enabled = false;
            O();
        }
    }

    private void O()
    {
        restart.gameObject.SetActive(true);
        mainMenu.gameObject.SetActive(true);

        restart.onClick.AddListener(Z);
        mainMenu.onClick.AddListener(F);

        p.volumeLayer = dedLayer;
    }

    void Z()
    {
        SceneManager.LoadScene("Main");
    }

    private void F()
    {
        SceneManager.LoadScene("menu");
    }
}
