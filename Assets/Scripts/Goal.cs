using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{

    [SerializeField] private GameObject m_player;
    [SerializeField] private GameObject m_goalTextObject;
    // Start is called before the first frame update
    void Start()
    {
        Text m_goalText = m_goalTextObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //コライダーが当たったら最初に呼ばれる
        //collisionに相手側の情報が格納される。
        Debug.Log(collision.gameObject.name);
        m_goalTextObject = collision.gameObject;
    }
}
