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
        if (Input.GetAxisRaw("Horizontal") >  0)
        {
            S
        }
    }

    private void FixedUpdate()
    {
        if (canGrab)
        {

        }
        else
        {
            
            if ()
            {
                Debug.Log("test");
                grabPoint.offset = new Vector2(this.transform.position.x + 1.0f, this.transform.position.y);
            }
            else if(rb.velocity.x < 0)
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
