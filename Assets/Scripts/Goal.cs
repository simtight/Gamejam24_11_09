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
        //�R���C�_�[������������ŏ��ɌĂ΂��
        //collision�ɑ��葤�̏�񂪊i�[�����B
        Debug.Log(collision.gameObject.name);
        m_goalTextObject = collision.gameObject;
    }
}
