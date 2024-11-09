using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleToStageSelect : MonoBehaviour
{
    public void TitleToStageSelectButton()
    {
        SceneManager.LoadScene(1);
    }
}
