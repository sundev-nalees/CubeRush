using UnityEngine.SceneManagement;
using UnityEngine;

public class Welcom : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
