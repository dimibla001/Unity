using UnityEngine;

public class ClickableObject : MonoBehaviour
{
    private ClickObjectsController gameController;

    void Start()
    {
        gameController = FindObjectOfType<ClickObjectsController>();
    }

    void OnMouseDown()
    {
        gameController.AddPoint();
        Destroy(gameObject); 
    }
}
