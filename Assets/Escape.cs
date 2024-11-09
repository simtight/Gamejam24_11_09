using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Escape : MonoBehaviour
{
    public GameObject panel;
    public TextMesh text;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1.0f;  
    }

    // Update is called once per frame
    void Update()
    {
            if(Input.GetKeyUp(KeyCode.Escape))
            {
                if(Time.timeScale == 0 )
            {
                panel.SetActive(true);
                text.text = "Pause";
                Time.timeScale = 0f;
            }
            else
            {
                panel.SetActive(false); 
                Time.timeScale = 1f;
            }
        }
    }
}
