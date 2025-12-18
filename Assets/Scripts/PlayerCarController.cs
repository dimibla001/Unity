using UnityEngine;

public class PlayerCarController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float turnSpeed = 100f;

    void Update()
    {
        float move = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        float turn = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;

        transform.Translate(0, 0, move);
        transform.Rotate(0, turn, 0);
    }
}
