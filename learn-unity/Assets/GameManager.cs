using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    // Start is called before the first frame update
    public void GameOver() 
    { 
        if (!gameHasEnded) {
            gameHasEnded = true;
            Restart();
        }
        
    }

    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
