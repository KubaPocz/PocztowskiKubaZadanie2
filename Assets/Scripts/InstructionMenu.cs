using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionMenu : MonoBehaviour
{
    [SerializeField]
    private Canvas MainMenuCanvas;
    public void ToMainMenu()
    {
        gameObject.SetActive(false);
        MainMenuCanvas.gameObject.SetActive(true);
    }
}
