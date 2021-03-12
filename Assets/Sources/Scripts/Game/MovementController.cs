using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    private Rigidbody2D thisRigidbody;
    private Transform thisTransform;

    private float acceleration = 2;
    //private float thisVelocity = 10;
    public float specialObjectAdditiveSpeed = 0;
    public float xCycleOffset = -16;

    private void Awake()
    {
        acceleration = Constants.acceleration;

        thisTransform = GetComponent<Transform>();
        thisRigidbody = GetComponent<Rigidbody2D>();
        //thisRigidbody.velocity = new Vector2(-3,0);
    }

    private void Update()
    {        
        if (thisTransform.localPosition.x <= xCycleOffset)
        {
            thisTransform.localPosition = new Vector3(thisTransform.localPosition.x - xCycleOffset, 0, 0);
        }

        float xPos = thisTransform.localPosition.x - ((Constants.thisVelocity+ specialObjectAdditiveSpeed) * Time.deltaTime);
        thisTransform.localPosition = new Vector3(xPos, thisTransform.localPosition.y, thisTransform.localPosition.z);

        //Debug.Log(Constants.thisVelocity);
    }


}
