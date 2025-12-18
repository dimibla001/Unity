using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 8f;

    void LateUpdate()
    {
        if (!target) return;

        transform.position = Vector3.Lerp(
            transform.position,
            target.position,
            smoothSpeed * Time.deltaTime
        );
    }
}
