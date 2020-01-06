using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonStartNewGame : MonoBehaviour
{
    public void StartNewGame()
    {
        SceneManager.LoadScene("Game");
    }    
}
