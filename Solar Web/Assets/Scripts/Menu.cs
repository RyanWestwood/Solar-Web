using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Menu : MonoBehaviour
{
    public GameObject settingsMenu;
    private bool settingMenuActive = false;

    public void SettingsMenu()
    {
        settingMenuActive = !settingMenuActive;
        settingsMenu.SetActive(settingMenuActive);
    }

    public void Play()
    {
        Debug.Log("Playing...");
    }

    public void Quit()
    {
        Debug.Log("Quitting...");
    }
}
