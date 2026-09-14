using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    public static bool hasKey = false;

    public GameManager gameTimer;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            hasKey = true;
            //adds 30 secs
            gameTimer.timeRemaining += 30f;

            // Remove the key from the map
            gameObject.SetActive(false);

            Debug.Log("Key collected!");
        }
    }
}
