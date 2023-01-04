using UnityEngine;

public class Credits : MonoBehaviour
{
    [SerializeField] private void Quit()
    {
        Application.Quit();
        Debug.Log("quit");
    }
}