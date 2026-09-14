using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [Header("Timer Settings")]
    public float timeRemaining = 90f;

    [Header("Score")]
    public int score = 0;
    public TMP_Text scoreText;
    public TMP_Text winScoreText;

    [Header("UI")]
    public TMP_Text timerText;
    public GameObject loseScreen;

    // Keeps track of whether the timer is currently counting down
    private bool timerRunning = true;

    public MonoBehaviour playerMovement;

    void Start()
    {
        loseScreen.SetActive(false);

        UpdateTimerDisplay();
        UpdateWinScoreDisplay();
        UpdateScoreDisplay();
    }

    void Update()
    {
        if (!timerRunning)
        {
            return;
        }

        // Continue counting down as long as there is time remaining
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;

            // Check if the timer has reached zero
            if (timeRemaining <= 0)
            {
                timeRemaining = 0;

                // End the game because the player ran out of time
                LoseGame();
            }

            // Update the timer text on the screen
            UpdateTimerDisplay();
        }
    }

    void UpdateTimerDisplay()
    {
        // Calculate how many full minutes are left(Mathf.FloorToInt:returns the largest integer less than or equal to a given float value)
        int minutes = Mathf.FloorToInt(timeRemaining / 60);

        // Calculate how many seconds are left after the minutes(Mathf.FloorToInt:returns the largest integer less than or equal to a given float value)
        int seconds = Mathf.FloorToInt(timeRemaining % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void UpdateScoreDisplay()
    {
        // Update the score text on the screen
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }


    void UpdateWinScoreDisplay()
    {
        // Update the score text on the win screen
        if (winScoreText != null)
        {
            winScoreText.text = "Score: " + score;
        }
    }

    // Called when the player collects a coin
    public void CollectCoin(GameObject coin)
    {
        // Increase the player's score by one
        score += 1;

        // Update the score text
        UpdateScoreDisplay();
        UpdateWinScoreDisplay();



        // Destroy the coin after it is collected
        Destroy(coin);
    }

    // Called when the timer reaches zero
    void LoseGame()
    {
        timerRunning = false;

        if (playerMovement != null)
        {
            playerMovement.enabled = false;
        }

        loseScreen.SetActive(true);//unhides the Lose panel and text on the canvas.
    }

    public void StopTimer()
    {
        timerRunning = false;

        if (playerMovement != null)
        {
            playerMovement.enabled = false;
        }
    }
}
