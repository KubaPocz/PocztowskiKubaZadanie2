using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    private Canvas MainMenuCanvas;
    [SerializeField]
    private Canvas StartMenuCanvas;
    [SerializeField]
    private Canvas DisplayMenuCanvas;
    [SerializeField]
    private Canvas SoundMenuCanvas;
    [SerializeField]
    private Canvas InstructionMenuCanvas;
    [SerializeField]
    private Canvas ExitMenuCanvas;
    public void ToStartMenu()
    {
        MainMenuCanvas.gameObject.SetActive(false);
        StartMenuCanvas.gameObject.SetActive(true);
    }
    public void ToDisplayMenu()
    {
        MainMenuCanvas.gameObject.SetActive(false);
        DisplayMenuCanvas.gameObject.SetActive(true);
    }
    public void ToSoundMenu()
    {
        MainMenuCanvas.gameObject.SetActive(false);
        SoundMenuCanvas.gameObject.SetActive(true);
    }
    public void ToInstructionMenu()
    {
        MainMenuCanvas.gameObject.SetActive(false);
        InstructionMenuCanvas.gameObject.SetActive(true);
    }
    public void ToExitMenu()
    {
        MainMenuCanvas.gameObject.SetActive(false);
        ExitMenuCanvas.gameObject.SetActive(true);
    }
}
