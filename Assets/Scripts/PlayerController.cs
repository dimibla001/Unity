using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float boundary = 4.5f; 

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(h, 0, v) * moveSpeed;
        rb.linearVelocity = new Vector3(move.x, rb.linearVelocity.y, move.z);


        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -boundary, boundary);
        pos.z = Mathf.Clamp(pos.z, -boundary, boundary);
        transform.position = pos;
    }
}
