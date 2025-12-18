using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreTimer : MonoBehaviour
{
    [Header("UI")]
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI scoreText;

    [Header("Game Settings")]
    public float gameDuration = 30f;

    private float timeRemaining;
    private int score = 0;

    void Start()
    {
        timeRemaining = gameDuration;
        UpdateTimerText();
        UpdateScoreText();
    }

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            if (timeRemaining < 0) timeRemaining = 0;
            UpdateTimerText();
        }
        else
        {
            GameOver();
        }
    }


    public void AddScore(int value)
    {
        score += value;
        UpdateScoreText();
    }

    private void UpdateTimerText()
    {
        if(timerText != null)
            timerText.text = "Time: " + Mathf.CeilToInt(timeRemaining);
    }

    private void UpdateScoreText()
    {
        if(scoreText != null)
            scoreText.text = "Score: " + score;
    }

    private void GameOver()
    {
        Debug.Log("Game Over! Final Score: " + score);
        SceneManager.LoadScene("MainMenu");
    }
}
