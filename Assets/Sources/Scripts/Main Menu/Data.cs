using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{
    public static bool hasFirstStart;

    public static string nickname { get; private set; }
    public static string imei { get; private set; }
    public static int coinsCount { get; set; }

    public GameObject firstStartPanel;
    public GameObject mainMenuPanel;

    private void Awake()
    {
        if (PlayerPrefs.HasKey("hasFirstStart"))
        {
            if (PlayerPrefs.GetInt("hasFirstStart") == 1) hasFirstStart = true;
            if (PlayerPrefs.GetInt("hasFirstStart") == 0) hasFirstStart = false;
        }
        else {
            hasFirstStart = false;
            PlayerPrefs.SetInt("hasFirstStart", 0);
        }

        if (PlayerPrefs.HasKey("nickname"))
        {
            nickname = PlayerPrefs.GetString("nickname");
        }
        if (PlayerPrefs.HasKey("imei"))
        {
            imei = PlayerPrefs.GetString("imei");
        }
        else 
        {
            imei = SystemInfo.deviceUniqueIdentifier;
            PlayerPrefs.SetString("imei", imei);
        }
        if (PlayerPrefs.HasKey("coinsCount")) 
        {
            coinsCount = PlayerPrefs.GetInt("coinsCount");
        }

        LoadMenu();
    }

    public void LoadMenu() 
    {
        if (!hasFirstStart)
        {
            firstStartPanel.SetActive(true);
        }
        else 
        {
            mainMenuPanel.SetActive(true);
        }
        
    }
}
