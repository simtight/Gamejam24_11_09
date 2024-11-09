using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameController : MonoBehaviour
{
    bool flagm;
    bool flagi;
    GameObject midd;
    GameObject FrameIn;

    // Start is called before the first frame update
    void Start()
    {
        midd = GameObject.Find("FrameMiddel");
        FrameIn = GameObject.Find("FrameIn");
        flagm = true;
        flagi = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            midd.SetActive(!flagm);
            flagm = !flagm;
        }
        if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            FrameIn.SetActive(!flagi);
            flagi = !flagi;
        }
    }
}
