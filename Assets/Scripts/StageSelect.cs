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
        //�X�e�[�W�Q�̃V�[��������
        //SceneManager.LoadScene("Stage2");
    }
    public void StageSelectButtonPressedThree()
    {
        //�X�e�[�W�R�̃V�[��������
        //SceneManager.LoadScene("Stage3");
    }
}
