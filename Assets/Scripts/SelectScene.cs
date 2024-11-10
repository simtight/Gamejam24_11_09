using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectScene : MonoBehaviour
{
    public void ToStageSelect()
    {
        SceneManager.LoadScene(1);
    }
    public void StageSelectOne()
    {
        SceneManager.LoadScene(2);
    }
    public void StageSelectTwo()
    {
        //ステージ２のシーン名入力
        SceneManager.LoadScene(3);
    }
    public void StageSelectThree()
    {
        //ステージ３のシーン名入力
        SceneManager.LoadScene(4);
    }
    public void ToTitle() 
    {
        SceneManager.LoadScene("Title");
    }
    public void ToApplicationQuit()
    {
        Application.Quit();
    }
}
