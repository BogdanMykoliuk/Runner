using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Progress : MonoBehaviour
{
    public static float playerScore = 0;
    public static int playerCoins { get; private set; } = 0;

    private void Awake()
    {
        playerScore = 0;
        playerCoins = Data.coinsCount;
    }
    private void Update()
    {
        playerScore += Time.deltaTime*10;
    }

    public static void AddCoins(int count) 
    {
        playerCoins += count;
        Data.coinsCount = playerCoins;
        PlayerPrefs.SetInt("coinsCount", playerCoins);
    }
}
