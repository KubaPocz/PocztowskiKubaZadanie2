using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundMenu : MonoBehaviour
{
    [SerializeField]
    private Canvas MainMenuCanvas;
    [SerializeField]
    private Toggle MusicCheckbox;
    [SerializeField]
    private Toggle SoundEffectsCheckbox;
    [SerializeField]
    private Slider VolumeSlider;
    public MenuLoader menuLoader;
    private void Awake()
    {
        menuLoader = FindAnyObjectByType<MenuLoader>();
    }

    private void Start()
    {
        MusicCheckbox.isOn = (menuLoader.music == "On" ? true : false);
        SoundEffectsCheckbox.isOn = (menuLoader.soundEffects == "On" ? true : false);
        VolumeSlider.value = menuLoader.volume;
    }
    public void ToMainMenu()
    {
        menuLoader.music = (MusicCheckbox.isOn ? "On" : "Off");
        menuLoader.soundEffects = (SoundEffectsCheckbox.isOn ? "On" : "Off");
        menuLoader.volume = VolumeSlider.value;
        gameObject.SetActive(false);
        MainMenuCanvas.gameObject.SetActive(true);
    }
}
