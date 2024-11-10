using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_move : MonoBehaviour
{
    [SerializeField] private CircleCollider2D m_collider;
    [SerializeField] private GameObject m_player;
    
    Rigidbody2D m_Rigidbody;
    private Animator anim;

    public int num;

    public float x;
    public float y;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = m_player.GetComponent<Rigidbody2D>();
        anim = m_player.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision == m_collider)
        {
            x = 0;
            y = 0;
            if (num == 0)
            {
                y += Time.deltaTime * speed;
                anim.SetFloat("X", 0f);
                anim.SetFloat("Y", 1f);
            }
            else if (num == 1)
            {
                y -= Time.deltaTime * speed;
                anim.SetFloat("X", 0f);
                anim.SetFloat("Y", -1f);
            }
            else if (num == 2)
            {
                x += Time.deltaTime * speed;
                anim.SetFloat("X", 1f);
                anim.SetFloat("Y", 0f);
            }
            else if (num == 3)
            {
                x -= Time.deltaTime * speed;
                anim.SetFloat("X", -1f);
                anim.SetFloat("Y", 0f);
            }
            //m_player.transform.position += new Vector3(x, y, 0);
            m_Rigidbody.velocity = new Vector3(x, y, 0);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        m_Rigidbody.velocity = new Vector3(0, 0, 0);
    }
}
