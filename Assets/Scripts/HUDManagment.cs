using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HUDManagment : MonoBehaviour
{
    [SerializeField]
    private Sprite[] equipment;
    [SerializeField]
    private Image currnetWeapon;
    private uint currnetWeaponId = 0;
    [SerializeField]
    private Image healthBar;
    [SerializeField]
    private GameObject inventory;
    [SerializeField]
    private GameObject HUD;
    private void Start()
    {
        currnetWeapon.sprite = equipment[currnetWeaponId];
    }
    private void Update()
    {
        if(Input.mouseScrollDelta.y > 0)
        {
            currnetWeaponId++;
            if (currnetWeaponId == uint.MaxValue)
            {
                currnetWeaponId++;
            }
            currnetWeapon.sprite = equipment[currnetWeaponId%equipment.Length];
        }
        else if(Input.mouseScrollDelta.y < 0)
        {
            currnetWeaponId--;
            if(currnetWeaponId == uint.MaxValue)
            {
                currnetWeaponId--;
            }
            currnetWeapon.sprite = equipment[currnetWeaponId%equipment.Length];
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            healthBar.fillAmount+=0.2f;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadSceneAsync("Menu");
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            inventory.SetActive(!inventory.activeInHierarchy);
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            HUD.SetActive(!HUD.activeInHierarchy);
        }
        if (Input.GetKeyDown(KeyCode.Delete))
        {
            PlayerPrefs.Save();
            Application.Quit();
        }
    }
}
