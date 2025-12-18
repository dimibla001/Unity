using UnityEngine;

public class RunnerMovement : MonoBehaviour
{
    public float forwardSpeed = 6f;
    public float sideSpeed = 5f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");

        Vector3 velocity = new Vector3(
            horizontal * sideSpeed,
            rb.linearVelocity.y,
            forwardSpeed
        );

        rb.linearVelocity = velocity;
    }
}
