using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerBoxGrab : MonoBehaviour
{
    [SerializeField] private CircleCollider2D grabPoint;
    [SerializeField] private Rigidbody2D rb;
    private bool canGrab = false;
    private bool isRight = false;
    private bool isLeft = false;
    private bool isDown = false;
    private bool isUp = false;

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            canGrab = true;
        }
        else
        {
            canGrab = false;
        }
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            isLeft = true;
        }
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            isRight = true;
        }
        if (Input.GetAxisRaw("Vertical") > 0)
        {
            isUp = true;
        }
        if (Input.GetAxisRaw("Vertical") < 0)
        {
            isDown = true;
        }
    }
        

    private void FixedUpdate()
    {
        if (canGrab)
        {

        }
        else
        {
            
            if (isRight)
            {
                Debug.Log("test");
                grabPoint.offset = new Vector2(this.transform.position.x + 1.0f, this.transform.position.y);
            }
            else if(isLeft)
            {
                grabPoint.offset = new Vector2(this.transform.position.x - 1.0f, this.transform.position.y);
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (canGrab)
        {

        }
    }

}
