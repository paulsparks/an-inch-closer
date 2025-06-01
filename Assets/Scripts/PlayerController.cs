using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerHead;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        playerHead.linearVelocity = new Vector3(0, 1, 0);
    }
}
