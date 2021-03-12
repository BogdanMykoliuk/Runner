using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Transform thisTransform;
    private Animator thisAnimator;

    public float speed = 1;

    private int linePosition = 0;    // -1 - sky, 0 - ground, 1 - underground

    public GameObject DeathPanel;
    private float startFingerPositionY;
    private float endFingerPositionY;

    private void Awake()
    {
        thisTransform = GetComponent<Transform>();
        thisAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            startFingerPositionY = Input.mousePosition.y;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            endFingerPositionY = Input.mousePosition.y;
            if (Mathf.Abs(startFingerPositionY - endFingerPositionY) >= 20) 
            {
                MovePlayer(startFingerPositionY < endFingerPositionY);
            }
            
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Enemy") 
        {
            Time.timeScale = 0;
            DeathPanel.SetActive(true);
        }
    }
    public void MovePlayer(bool toUp) 
    {
        if (toUp && linePosition != -1) 
        {
            linePosition -= 1;
        }
        else if (!toUp && linePosition != 1)
        {
            linePosition += 1;
        }

        Vector3 targetPosition = new Vector3(-8, -0.71f, 0);
        if (linePosition == -1)
        {
            targetPosition.y = 1.5f;
        }
        else if (linePosition == 1)
        {
            targetPosition.y = -3.5f;
        }

        var corutine = Move(targetPosition);
        StartCoroutine(corutine);
        thisAnimator.SetInteger("toLevel", linePosition);
    }

    public IEnumerator Move(Vector3 targetPosition) 
    {
        
        while (thisTransform.position != targetPosition) {
            thisTransform.position = Vector3.MoveTowards(thisTransform.position, targetPosition, speed * Time.deltaTime);
            yield return new WaitForEndOfFrame();
        }
        yield break;

    }
}
