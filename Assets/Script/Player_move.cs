using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_move : MonoBehaviour
{
    [SerializeField] GameObject m_player;
    
    Rigidbody2D m_Rigidbody;

    public int num;

    public float x;
    public float y;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        m_Rigidbody = m_player.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            x = 0;
            y = 0;
            if (num == 0)
            {
                y += Time.deltaTime * speed;
            }
            else if (num == 1)
            {
                y -= Time.deltaTime * speed;
            }
            else if (num == 2)
            {
                x += Time.deltaTime * speed;
            }
            else if (num == 3)
            {
                x -= Time.deltaTime * speed;
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
