using UnityEngine;

public class KeyLock : MonoBehaviour
{
    public GameObject winScreen;
    public GameManager gameTimer;

    private bool gameWon;

    void WinGame ()
    {
        gameWon = true;
        //Stop timer
        if (gameTimer != null)
        {
            gameTimer.StopTimer();
        }

        //Shows the win screen
        winScreen.SetActive(true);

        Debug.Log("You win!");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (gameWon)
            return;

        if(other.CompareTag("Player") && KeyPickup.hasKey)
        {
            WinGame();
        }
    }
}
