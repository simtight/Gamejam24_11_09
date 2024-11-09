using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageSelect : MonoBehaviour
{
    public void StageSelectButtonPressedOne()
    {
        SceneManager.LoadScene("stagecreate");
    }
    public void StageSelectButtonPressedTwo()
    {
        //ステージ２のシーン名入力
        //SceneManager.LoadScene("Stage2");
    }
    public void StageSelectButtonPressedThree()
    {
        //ステージ３のシーン名入力
        //SceneManager.LoadScene("Stage3");
    }
}
