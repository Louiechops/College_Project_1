using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
   public void Restart()
    {
        //Resets the key
        KeyPickup.hasKey = false;

        //Realoads current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
