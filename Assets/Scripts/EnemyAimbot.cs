using UnityEngine;

public class EnemyAimbot : MonoBehaviour
{
    public Transform shootPoint;
    public GameObject bulletPrefab;
    public float shootInterval = 2f;

    private Transform player;
    private float shootTimer;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        shootTimer = shootInterval;
    }

    private void Update()
    {
        if (player == null) return;

       
        Vector3 direction = (player.position - transform.position).normalized;
        direction.y = 0; 
        transform.rotation = Quaternion.LookRotation(direction);

        
        shootTimer -= Time.deltaTime;
        if (shootTimer <= 0f)
        {
            Shoot();
            shootTimer = shootInterval;
        }
    }

    private void Shoot()
    {
        if (bulletPrefab != null && shootPoint != null)
        {
            GameObject bullet = Instantiate(bulletPrefab, shootPoint.position, shootPoint.rotation);
        }
    }
}
