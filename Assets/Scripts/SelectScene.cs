using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectScene : MonoBehaviour
{
    public void TitleToStageSelectButton()
    {
        SceneManager.LoadScene(1);
    }
    public void StageSelectOne()
    {
        SceneManager.LoadScene(2);
    }
    public void StageSelectTwo()
    {
        //�X�e�[�W�Q�̃V�[��������
        //SceneManager.LoadScene(3);
    }
    public void StageSelectThree()
    {
        //�X�e�[�W�R�̃V�[��������
        //SceneManager.LoadScene(4);
    }
    public void ToStageSelect() 
    {
        SceneManager.LoadScene(1);
    }
}
