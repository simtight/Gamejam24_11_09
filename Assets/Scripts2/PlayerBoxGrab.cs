using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerBoxGrab : MonoBehaviour
{
    [SerializeField] private CircleCollider2D grabPoint;
    [SerializeField] private BoxCollider2D boxCollider;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed;
    private GameObject hitCollider;
    private bool canGrab = false;
    private bool isRight = false;
    private bool isLeft = false;
    private bool isDown = false;
    private bool isUp = false;
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
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
        rb.velocity = Vector3.zero;
        boxCollider.offset = Vector2.zero;
        boxCollider.size = new Vector2(0.2f, 0.2f);
        if(!canGrab&&hitCollider != null)
        {
            hitCollider.GetComponent<BoxCollider2D>().size = new Vector2(1f, 1f);
        }
        if (canGrab&&hitCollider!=null)
        {
            Debug.Log("Grab");
            hitCollider.transform.position = new Vector3(this.transform.position.x + grabPoint.offset.x*this.transform.localScale.x, this.transform.position.y + grabPoint.offset.y* this.transform.localScale.y, 0);
            hitCollider.GetComponent<BoxCollider2D>().size = new Vector2(0.2f, 0.2f);
            
            if(grabPoint.offset.x > 0)
            {
                boxCollider.offset = new Vector2(grabPoint.offset.x+0.12f,grabPoint.offset.y);
                boxCollider.size = new Vector2(0.1f, 0.33f);
                if (isRight)
                {
                    rb.velocity = new Vector3(speed, 0, 0);
                }
                else if(isLeft)
                {
                    rb.velocity = new Vector3(-speed, 0, 0);
                }
            }
            else if(grabPoint.offset.x < 0)
            {
                boxCollider.offset = new Vector2(grabPoint.offset.x - 0.12f, grabPoint.offset.y);
                boxCollider.size = new Vector2(0.1f, 0.33f);
                if (isRight)
                {
                    rb.velocity = new Vector3(speed, 0, 0);
                }
                else if (isLeft)
                {
                    rb.velocity = new Vector3(-speed, 0, 0);
                }
            }
            else if(grabPoint.offset.y > 0)
            {
                boxCollider.offset = new Vector2(grabPoint.offset.x, grabPoint.offset.y+0.16f);
                boxCollider.size = new Vector2(0.33f, 0.1f);
                if (isUp)
                {
                    rb.velocity = new Vector3(0,speed, 0);
                }
                else if (isDown)
                {
                    rb.velocity = new Vector3(0, -speed, 0);
                }
            }
            else if(grabPoint.offset.y < 0)
            {
                boxCollider.offset = new Vector2(grabPoint.offset.x, grabPoint.offset.y - 0.16f);
                boxCollider.size = new Vector2(0.33f, 0.1f);
                if (isUp)
                {
                    rb.velocity = new Vector3(0, speed, 0);
                }
                else if (isDown)
                {
                    rb.velocity = new Vector3(0, -speed, 0);
                }
            }
            
        }
        else
        {
            
            if (isRight)
            {
                Debug.Log("Right");
                grabPoint.offset = new Vector2(0.4f, -0.1f);
                anim.SetFloat("X", grabPoint.offset.x);
                anim.SetFloat("Y", grabPoint.offset.y);
                rb.velocity = new Vector3(speed, 0, 0);
            }
            else if(isLeft)
            {
                Debug.Log("Left");
                grabPoint.offset = new Vector2(-0.4f, -0.1f);
                anim.SetFloat("X", grabPoint.offset.x);
                anim.SetFloat("Y", grabPoint.offset.y);
                rb.velocity = new Vector3(-speed, 0, 0);

            }
            else if (isUp)
            {
                grabPoint.offset= new Vector2(0f, 0.55f);
                anim.SetFloat("X", grabPoint.offset.x);
                anim.SetFloat("Y", grabPoint.offset.y);
                rb.velocity = new Vector3(0, speed, 0);
            }
            else if(isDown)
            {
                grabPoint.offset = new Vector2(0.0f, -0.65f);
                anim.SetFloat("X", grabPoint.offset.x);
                anim.SetFloat("Y", grabPoint.offset.y);
                rb.velocity = new Vector3(0, -speed, 0);
            }
            //anim.SetFloat("X", grabPoint.offset.x);
            //anim.SetFloat("Y", grabPoint.offset.y);
        }
    }
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Box")
        {
            Debug.Log("test");
            hitCollider = collision.gameObject;
            
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Box")
        {
            hitCollider = null;
            collision.gameObject.GetComponent<BoxCollider2D>().size = new Vector2(1f, 1f);
        }
    }

}
