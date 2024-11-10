using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoPanelBack : MonoBehaviour
{
    [SerializeField] private GameObject InfoPanel;
    [SerializeField] private GameObject PausePanel;

    AudioSource audio;
    public AudioClip SE;
    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    public void ShowPanel()
    {
        audio.PlayOneShot(SE);
        Time.timeScale = 0.0f;
        PausePanel.SetActive(false);
        InfoPanel.SetActive(true);
        
    }

    public void BackPanel()
    {
        audio.PlayOneShot(SE);
        Time.timeScale = 1.0f;
        InfoPanel.SetActive(false);
    }
}
