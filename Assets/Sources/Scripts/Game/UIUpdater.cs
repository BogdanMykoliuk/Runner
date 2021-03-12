using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIUpdater : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text coinsText;

    private static TMP_Text _scoreText;
    private static TMP_Text _coinsText;

    private void Awake()
    {
        _coinsText = coinsText;
        _scoreText = scoreText;

        UpdateCoinsText();
        UpdateScoreText();
    }

    private void Update()
    {
        UpdateScoreText();
    }

    public static void UpdateScoreText() 
    {
        _scoreText.text = $"{Mathf.Floor(Progress.playerScore)}";
    }

    public static void UpdateCoinsText()
    {
        _coinsText.text = $"{Data.coinsCount}";
    }
}
