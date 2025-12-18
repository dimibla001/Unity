using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;       
    public int damage = 1;           
    private Transform player;        
    private Vector3 direction;      

    void Start()
    {
        
        player = GameObject.FindGameObjectWithTag("Player")?.transform;
        if (player != null)
        {
            direction = (player.position - transform.position).normalized;
        }
        else
        {
            Debug.LogWarning("Player not found!");
            direction = Vector3.forward;
        }
    }

    void Update()
    {
        transform.position += direction * speed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        ScoreTimer scoreTimer = FindObjectOfType<ScoreTimer>();

       
        if (other.CompareTag("Player"))
        {
            if(scoreTimer != null)
                scoreTimer.AddScore(-2); 
            Destroy(gameObject);
        }
      
        else if (other.CompareTag("Boundary"))
        {
            if(scoreTimer != null)
                scoreTimer.AddScore(1); 
            Destroy(gameObject);
        }
    }

    private void OnBecameInvisible()
    {
        
        ScoreTimer scoreTimer = FindObjectOfType<ScoreTimer>();
        if(scoreTimer != null)
            scoreTimer.AddScore(1);
        Destroy(gameObject);
    }
}
