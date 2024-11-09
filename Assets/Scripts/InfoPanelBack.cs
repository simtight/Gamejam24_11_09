using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoPanelBack : MonoBehaviour
{
    [SerializeField] private GameObject InfoPanel;
    [SerializeField] private GameObject PausePanel;

    public void ShowPanel()
    {
        Time.timeScale = 0.0f;
        PausePanel.SetActive(false);
        InfoPanel.SetActive(true);
    }

    public void BackPanel()
    {
        Time.timeScale = 1.0f;
        InfoPanel.SetActive(false);
    }
}
