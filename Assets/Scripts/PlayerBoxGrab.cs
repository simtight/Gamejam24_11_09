using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerBoxGrab : MonoBehaviour
{
    [SerializeField] private CircleCollider2D grabPoint;
    [SerializeField] private Rigidbody2D rb;
    private GameObject hitCollider;
    private bool canGrab = false;
    private bool isRight = false;
    private bool isLeft = false;
    private bool isDown = false;
    private bool isUp = false;

    private void Update()
    {
        isRight = false;
        isLeft = false;
        isDown = false;
        isUp = false;
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
            isRight = true;
        }
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            isLeft = true;
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
        if (canGrab&&hitCollider!=null)
        {
            hitCollider.transform.position = new Vector3(this.transform.position.x + grabPoint.offset.x, this.transform.position.y + grabPoint.offset.y, 0);
        }
        else
        {
            
            if (isRight)
            {
                Debug.Log("Right");
                grabPoint.offset = new Vector2(1.0f, 0);
            }
            else if(isLeft)
            {
                Debug.Log("Left");
                grabPoint.offset = new Vector2(-1.0f, 0);
            }else if (isUp)
            {
                grabPoint.offset= new Vector2(0f, 1.0f);
            }else if(isDown)
            {
                grabPoint.offset = new Vector2(0.0f, -1.0f);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        hitCollider = collision.gameObject;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        hitCollider = null;
    }

}
