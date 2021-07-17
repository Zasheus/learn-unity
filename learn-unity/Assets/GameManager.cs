using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;

    // Start is called before the first frame update
    public void GameOver() 
    { 
        if (!gameHasEnded) {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }
        
    }

    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
