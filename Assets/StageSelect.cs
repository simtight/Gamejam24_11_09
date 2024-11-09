using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageSelect : MonoBehaviour
{
    public void StageSelectButtonPressedOne()
    {
        SceneManager.LoadScene("Stage1");
    }
    public void StageSelectButtonPressedTwo()
    {
        SceneManager.LoadScene("Stage2");
    }
    public void StageSelectButtonPressedThree()
    {
        SceneManager.LoadScene("Stage3");
    }
}
