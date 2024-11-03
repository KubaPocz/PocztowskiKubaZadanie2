using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuLoader : MonoBehaviour
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
    [NonSerialized]
    public string resolution;
    [NonSerialized]
    public string fullscreen;
    [NonSerialized]
    public string music;
    [NonSerialized]
    public string soundEffects;
    [NonSerialized]
    public float volume;
    private void Start()
    {
        resolution = PlayerPrefs.GetString("Resolution");
        fullscreen = PlayerPrefs.GetString("Fullscreen");
        music = PlayerPrefs.GetString("Music");
        soundEffects = PlayerPrefs.GetString("Sound Effects");
        volume = PlayerPrefs.GetFloat("Volume");
        MainMenuCanvas.gameObject.SetActive(true);
        StartMenuCanvas.gameObject.SetActive(false);
        DisplayMenuCanvas.gameObject.SetActive(false);
        SoundMenuCanvas.gameObject.SetActive(false);
        InstructionMenuCanvas.gameObject.SetActive(false);
        ExitMenuCanvas.gameObject.SetActive(false);
    }
}
