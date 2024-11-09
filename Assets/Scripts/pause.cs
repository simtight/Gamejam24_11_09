using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    [SerializeField] GameObject panel;
    public bool isPause = false;
    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
        isPause = false;
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            if (isPause == false)
            {
                panel.SetActive(true);
                Time.timeScale = 0f;
                isPause = true;
                Debug.Log(isPause);
            }
            else
            {
                panel.SetActive(false);
                Time.timeScale = 1f;
                isPause = false;
                Debug.Log(isPause);
            }
        }
    }
}
