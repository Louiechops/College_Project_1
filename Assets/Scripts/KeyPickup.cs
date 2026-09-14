using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    public static bool hasKey = false;

    public GameManager gameTimer;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))//Checks to see if what collided with the key object has the player Tag
        {
            hasKey = true;
            //adds 30 secs
            gameTimer.timeRemaining += 30f;

            // Remove the key from the map
            gameObject.SetActive(false);

            
        }
    }
}
