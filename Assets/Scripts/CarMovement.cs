using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float speed = 8f;
    public float turnSpeed = 60f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float move = Input.GetAxis("Vertical");
        float turn = Input.GetAxis("Horizontal");

        Vector3 forwardMove = transform.forward * move * speed;
        rb.MovePosition(rb.position + forwardMove * Time.fixedDeltaTime);

        Quaternion turnRotation = Quaternion.Euler(0f, turn * turnSpeed * Time.fixedDeltaTime, 0f);
        rb.MoveRotation(rb.rotation * turnRotation);
    }
}
