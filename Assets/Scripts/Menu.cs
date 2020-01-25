using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField] private TogglePanel _panelCreator;

    public void StartNewGame()
    {
        SceneManager.LoadScene("Game");
    }    

    public void OnButtonAnimationPanel()
    {
        _panelCreator.Toggle();
    }

    public void Quit()
    {
        Application.Quit();
    }
}
