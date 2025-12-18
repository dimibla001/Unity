using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [Header("Player Settings")]
    public int playerHealth = 3;

    [Header("Game Settings")]
    public int score = 0;
    public float timeLeft = 30f;
    public Text scoreText;
    public Text timerText;

    private bool gameEnded = false;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        if (gameEnded) return;

        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0f) EndGame();

        UpdateUI();
    }

    void UpdateUI()
    {
        if (scoreText) scoreText.text = "Score: " + score;
        if (timerText) timerText.text = "Time: " + Mathf.CeilToInt(timeLeft);
    }

    public void AddScore(int amount)
    {
        if (gameEnded) return;
        score += amount;
    }

    public void PlayerHit(int damage)
    {
        playerHealth -= damage;
        Debug.Log("Player hit! Health: " + playerHealth);

        if (playerHealth <= 0)
        {
            GameOver();
        }
    }

    void EndGame()
    {
        gameEnded = true;
        Debug.Log("Time's up! Game Over!");
        SceneManager.LoadScene("MainMenu");
    }

    public void GameOver()
    {
        gameEnded = true;
        Debug.Log("Game Over!");
        SceneManager.LoadScene("MainMenu");
    }
}
