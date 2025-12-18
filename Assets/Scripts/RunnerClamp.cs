using UnityEngine;

public class RunnerClamp : MonoBehaviour
{
    public float limitX = 2f;

    void Update()
    {
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -limitX, limitX);
        transform.position = pos;
    }
}
