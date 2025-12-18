using UnityEngine;
using TMPro;

public class ClickObjectsController : MonoBehaviour
{
    public GameObject clickablePrefab; 
    public TMP_Text scoreText;
    public int numberOfObjects = 16;

    private int score = 0;

    void Start()
    {
        float startX = -7f; 
        float step = 1f;    
        float y = 0.5f;    

        for (int i = 0; i < numberOfObjects; i++)
        {
            Vector3 pos = new Vector3(startX + i * step, y, 0);
            GameObject obj = Instantiate(clickablePrefab, pos, Quaternion.identity);
            obj.AddComponent<ClickableObject>(); 
        }

        UpdateScore();
    }

    public void AddPoint()
    {
        score++;
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }
}
