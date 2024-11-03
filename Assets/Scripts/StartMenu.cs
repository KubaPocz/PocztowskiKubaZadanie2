using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    [SerializeField]
    private Canvas MainMenuCanvas;
    public void ToMainMenu()
    {
        gameObject.SetActive(false);
        MainMenuCanvas.gameObject.SetActive(true);
    }
    public void StartGame()
    {
        SceneManager.LoadSceneAsync("HUD");
    }
}
