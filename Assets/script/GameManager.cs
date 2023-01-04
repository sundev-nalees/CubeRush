using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]private float restartDelay = 1f;
    [SerializeField] GameObject completeLevelUI;
    
    
    private bool gameHasEnded = false;
    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
        
    }
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("Restart",restartDelay);
        }
        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
