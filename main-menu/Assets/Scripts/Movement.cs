using System.Collections;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody rb;
    private Transform p;

    public float speedx;
    public float speedy;
    public float vmaxX;
    public float vmaxY;
    public float mew;

    public float jumpForce;
    public float trq;
    public bool isGrounded;
    public Transform GroundCheck;
    public ParticleSystem jumpEff;
    audioManage audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<audioManage>();
    }
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        p = GetComponent<Transform>();
    }

    void Update()
    {
        isGrounded = Physics.Raycast(GroundCheck.transform.position, Vector3.down, 0.55f);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce);
            rb.AddTorque(Vector3.right * trq);

            //adding jump effect
            audioManager.PlaySFX(audioManager.jump);
            

        }
    }

    void JumpEffect()
    {
        Instantiate(jumpEff, transform.position, transform.rotation);
    }

    private void FixedUpdate()
    {
        Move();
    }


    float x;
    float m;

    void Move()
    {
        x = Input.GetAxis("Horizontal");

        if (isGrounded) m = 1f;
        if (!isGrounded) m = 0.5f;

        if (x > 0f && rb.velocity.x > vmaxX) x = 0f;
        if(x < 0f && rb.velocity.x < -vmaxX) x = 0f;

        rb.AddForce(Vector3.right * x * speedx * m);

        if(rb.velocity.z < vmaxY)
        {
            rb.AddForce(Vector3.forward * speedy);
        }

        Friction();
    }

    void Friction()
    {
        if(Mathf.Abs(rb.velocity.x) > 0.01f && Mathf.Abs(x) < 0.05f || rb.velocity.x < -0.01f && x > 0f && rb.velocity.x > 0.01f && x < 0f)
        {
            rb.AddForce( -Vector3.right * rb.velocity.normalized.x * mew * speedx);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (Mathf.Abs(rb.velocity.y) > 0.1f)
        {
            JumpEffect();

        }
    }
}
