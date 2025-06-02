using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector3 jump;
    public float jumpForce = 2.0f;
    public bool isGrounded;
    public float speed = 5f;
    private Rigidbody rb;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

    void FixedUpdate()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            rb.AddForce(Vector3.forward * speed);
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            rb.AddForce(Vector3.back * speed);
        }

        if (Input.GetAxis("Vertical") > 0)
        {
            rb.AddForce(Vector3.left * speed);
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            rb.AddForce(Vector3.right * speed);
        }
    }

    void OnCollisionStay(Collision collision)
    {
        if (!(collision.gameObject.layer == 7) && !(collision.gameObject.layer == 6))
        {
            isGrounded = true;
        }
    }
    void OnCollisionExit()
    {
        isGrounded = false;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }
}
