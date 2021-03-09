using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathPanel : MonoBehaviour
{
    public void WatchVideo() 
    {
        //Time.timeScale = 1;
    }

    public void RestartGame() 
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
