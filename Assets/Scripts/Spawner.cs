using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float spawnInterval = 1.5f;
    public float boundary = 5f;

    void Start()
    {
        InvokeRepeating("SpawnBullet", 1f, spawnInterval);
    }

    void SpawnBullet()
    {
        float x = 0f;
        float z = 0f;

        int side = Random.Range(0, 4);
        switch(side)
        {
            case 0: x = -boundary; z = Random.Range(-boundary, boundary); break;
            case 1: x = boundary; z = Random.Range(-boundary, boundary); break;
            case 2: z = -boundary; x = Random.Range(-boundary, boundary); break;
            case 3: z = boundary; x = Random.Range(-boundary, boundary); break;
        }

        Vector3 spawnPos = new Vector3(x, 0.5f, z);
        Instantiate(bulletPrefab, spawnPos, Quaternion.identity);
    }
}
