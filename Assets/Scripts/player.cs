using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal") * Time.deltaTime * speed;
        float y = Input.GetAxisRaw("Vertical") * Time.deltaTime * speed;

        //動いてなければアニメーションの停止
        //if (x != 0 || y != 0)
        //{
            
        //}
        
        transform.position = new Vector3(Mathf.Clamp(this.transform.position.x + x, -8.86f, 8.86f),
        Mathf.Clamp(this.transform.position.y + y, -4.48f, 4.48f), 0);
    }
}
