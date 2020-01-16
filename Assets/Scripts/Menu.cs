using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField] private PanelCreatorMover _panelCreator;

    public void StartNewGame()
    {
        SceneManager.LoadScene("Game");
    }    

    public void OnButtonAnimationPanel()
    {
        _panelCreator.ShowCreator();
    }

    public void Quit()
    {
        Application.Quit();
    }
}
