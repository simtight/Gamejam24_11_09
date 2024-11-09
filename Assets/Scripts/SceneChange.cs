using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void OnStageSelectButton()
    {
        SceneManager.LoadScene("StageSelect");
    }
    public void OnStageOneButton()
    {
        SceneManager.LoadScene("Stage1");
    }
    public void OnStageTwoButton()
    {
        SceneManager.LoadScene("Stage2");
    }
    public void OnStageThreeButton()
    {
        SceneManager.LoadScene("Stage3");
    }
    public void ToTitle()
    {
        SceneManager.LoadScene("Title");
    }
}
