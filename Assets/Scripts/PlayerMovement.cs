using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float h = 0;
        float v = 0;

        if (Keyboard.current.aKey.isPressed) h = -1;
        if (Keyboard.current.dKey.isPressed) h = 1;
        if (Keyboard.current.sKey.isPressed) v = -1;
        if (Keyboard.current.wKey.isPressed) v = 1;

        Vector3 move = new Vector3(h, 0, v).normalized * speed;
        rb.linearVelocity = new Vector3(move.x, rb.linearVelocity.y, move.z);
    }
}
