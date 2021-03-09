using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Constants : MonoBehaviour
{
    public static float acceleration = 1;
    public static float thisVelocity = 10;
    public static float xCycleOffset = -16;

    private void Awake()
    {
        thisVelocity = 10;
    }

    private void Update()
    {
        if (thisVelocity < 20)
        {
            thisVelocity = thisVelocity + acceleration / 1000;
        }
    }
}
