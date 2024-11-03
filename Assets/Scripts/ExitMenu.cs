using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitMenu : MonoBehaviour
{
    [SerializeField]
    private Canvas MainMenuCanvas;
    private MenuLoader menuLoader;
    private void Awake()
    {
        menuLoader = FindAnyObjectByType<MenuLoader>();
    }
    public void ToMainMenu()
    {
        gameObject.SetActive(false);
        MainMenuCanvas.gameObject.SetActive(true);
    }
    public void SaveAndQuit()
    {
        PlayerPrefs.SetString("Resolution", menuLoader.resolution);
        PlayerPrefs.SetString("Fullscreen", menuLoader.fullscreen);
        PlayerPrefs.SetString("Music", menuLoader.music);
        PlayerPrefs.SetString("Sound Effects", menuLoader.soundEffects);
        PlayerPrefs.SetFloat("Volume", menuLoader.volume);
        PlayerPrefs.Save();
        Application.Quit();
    }
    public void Quit()
    {
        Application.Quit();
    }
}
