using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Progress : MonoBehaviour
{
    public static float playerScore = 0;

    private void Awake()
    {
        playerScore = 0;
    }
    private void Update()
    {
        playerScore += Time.deltaTime*10;
    }
}
