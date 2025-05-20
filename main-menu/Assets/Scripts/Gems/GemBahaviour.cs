using UnityEngine;

public class GemBahaviour : MonoBehaviour
{
    public ParticleSystem gemEff;
    audioManage audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<audioManage>();
    }

    private void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.CompareTag("Player"))
        {
            Score s = c.GetComponent<Score>();

            s.Scor();

            Instantiate(gemEff, transform.position, transform.rotation);

            Destroy(this.gameObject);
            //adding gem collection sound effect

            audioManager.PlaySFX(audioManager.gem);


        }
    }
}
