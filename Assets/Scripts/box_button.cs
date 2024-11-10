using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class box_button : MonoBehaviour
{
    [SerializeField] GameObject door;

    private bool door_open;
    private bool played;

    public AudioClip SE;
    AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        played = false;
        audio = GetComponent<AudioSource>();
        door_open = true;
    }

    // Update is called once per frame
    void Update()
    {
        door.SetActive(door_open);
    }

    private void OnTriggerStay2D(Collider2D collision)
    { 
        if(collision.gameObject.CompareTag("Box") /*&& !played*/)
        {
            audio.PlayOneShot(SE);
            door_open = false;
            played = !played;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Box") && played)
        {
            door_open = true;
            played = !played;
        }
    }
}
