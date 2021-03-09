using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIUpdater : MonoBehaviour
{
    public Text scoreText;

    private void Update()
    {
        UpdateScoreText();
    }

    public void UpdateScoreText() 
    {
        scoreText.text = $"Score: {Mathf.Floor(Progress.playerScore)}";
    }
}
