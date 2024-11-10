using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] AudioSource audiosource;
    //[SerializeField] AudioClip BGM;

    void Start()
    {
        audiosource.Play();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
