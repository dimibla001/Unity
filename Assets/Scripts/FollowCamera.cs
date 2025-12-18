using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [Header("Target to follow")]
    public Transform target; 

    [Header("Offset from target")]
    public Vector3 offset = new Vector3(0f, 5f, -10f); 

    [Header("Smoothness")]
    public float smoothSpeed = 0.125f; 

    void LateUpdate()
    {
        if (target == null) return;

     
        Vector3 desiredPosition = target.position + offset;


        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;


        transform.LookAt(target);
    }
}
