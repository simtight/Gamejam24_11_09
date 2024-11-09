using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoPanelBack : MonoBehaviour
{
    [SerializeField] private GameObject InfoPanel;

    public void ShowPanel()
    {
        InfoPanel.SetActive(true);
    }

    public void BackPanel()
    {
        InfoPanel.SetActive(false);
    }
}
