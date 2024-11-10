using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class box_button : MonoBehaviour
{
    [SerializeField] GameObject door;

    private bool door_open;
    // Start is called before the first frame update
    void Start()
    {
        door_open = true;
    }

    // Update is called once per frame
    void Update()
    {
        door.SetActive(door_open);
    }

    private void OnTriggerStay2D(Collider2D collision)
    { 
        if(collision.gameObject.CompareTag("Box"))
        {
            door_open = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Box"))
        {
            door_open = true;
        }
    }
}
