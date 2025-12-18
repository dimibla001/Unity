using UnityEngine;

public class Food : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Animal"))
        {
            FindObjectOfType<ScoreManager>().AddPoints(1);
            Destroy(gameObject);
        }
    }
}
