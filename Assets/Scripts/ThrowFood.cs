using UnityEngine;

public class ThrowFood : MonoBehaviour
{
    [Header("Throw Settings")]
    public GameObject foodPrefab;       
    public Transform throwPoint;       
    public float throwForce = 10f;      
    public float downwardAngle = 0.3f;  

    [Header("Optional")]
    public AudioClip throwSound;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if(audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            Throw();
        }
    }

    void Throw()
    {
        if(foodPrefab == null || throwPoint == null) return;


        GameObject foodInstance = Instantiate(foodPrefab, throwPoint.position, Quaternion.identity);

        Rigidbody rb = foodInstance.GetComponent<Rigidbody>();
        if(rb != null)
        {

            Vector3 throwDirection = (throwPoint.forward + Vector3.down * downwardAngle).normalized;


            rb.AddForce(throwDirection * throwForce, ForceMode.VelocityChange);
        }


        if(throwSound != null)
        {
            audioSource.PlayOneShot(throwSound);
        }
    }
}
