using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager gameManager = FindFirstObjectByType<GameManager>();// locate and return the first active, loaded instance of the GameManager script in the current scene.

            if (gameManager != null)
            {
                gameManager.CollectCoin(gameObject);
            }
        }
    }
}
