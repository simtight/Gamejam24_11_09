using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    public void GameStartButtonPressed()
    {
        SceneManager.LoadScene("StageSelect");
    }
}
