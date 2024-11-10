using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box_button2 : MonoBehaviour
{
    [SerializeField] GameObject door11;
    [SerializeField] GameObject door12;
    [SerializeField] GameObject door21;
    [SerializeField] GameObject door22;

    private bool door_open;
    private bool played;

    AudioSource audio;
    public AudioClip SE;
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
        door11.SetActive(door_open);
        door12.SetActive(!door_open);
        door21.SetActive(door_open);
        door22.SetActive(!door_open);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Box") && !played)
        {
            door_open = false;
            audio.PlayOneShot(SE);
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
