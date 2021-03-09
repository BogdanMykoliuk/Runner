using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstStart : MonoBehaviour
{
    public GameObject thisPanel;
    public GameObject mainMenuPanel;

    public Text nicknameText;
    public Button buttonStart;

    private void Update()
    {
        if (nicknameText.text != "")
        {
            buttonStart.interactable = true;
        }
        else 
        {
            buttonStart.interactable = false;
        }
    }

    public void SaveData()
    {
        PlayerPrefs.SetInt("hasFirstStart", 1);
        PlayerPrefs.SetString("nickname", nicknameText.text);
        mainMenuPanel.SetActive(true);
        thisPanel.SetActive(false);
    }
}
