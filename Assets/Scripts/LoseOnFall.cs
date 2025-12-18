using UnityEngine;

public class LoseOnFall : MonoBehaviour
{
    public GameObject losePanel;

    void Update()
    {
        if (transform.position.y < -5f)
        {
            losePanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
