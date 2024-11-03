using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class DisplayMenu : MonoBehaviour
{
    [SerializeField]
    private Canvas MainMenuCanvas;
    [SerializeField]
    private Dropdown ResolutionDropdown;
    [SerializeField]
    private Toggle FullScreenCheckbox;
    private MenuLoader menuLoader;
    private void Awake()
    {
        menuLoader = FindAnyObjectByType<MenuLoader>();
    }

    private void Start()
    {
        ResolutionDropdown.value = (menuLoader.resolution == "1920x1080 (16:9)" ? 0 : menuLoader.resolution == "1920×1200 (16:10)" ? 1 : menuLoader.resolution == "1600×1200 (4:3)" ? 2 : 0);
        FullScreenCheckbox.isOn = (menuLoader.fullscreen == "On" ? true : false);
    }
    public void ToMainMenu()
    {
        menuLoader.resolution = ResolutionDropdown.options[ResolutionDropdown.value].text;
        menuLoader.fullscreen = (FullScreenCheckbox.isOn ? "On" : "Off");
        gameObject.SetActive(false);
        MainMenuCanvas.gameObject.SetActive(true);
    }

}
