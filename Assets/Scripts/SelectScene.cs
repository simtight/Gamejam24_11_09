using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectScene : MonoBehaviour
{
    public AudioClip SE;
    AudioSource audio;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    public void ToStageSelect()
    {
        SceneManager.LoadScene(1);
        audio.PlayOneShot(SE);
    }
    public void StageSelectOne()
    {
        audio.PlayOneShot(SE);
        SceneManager.LoadScene(2);
    }
    public void StageSelectTwo()
    {
        //�X�e�[�W�Q�̃V�[��������
        audio.PlayOneShot(SE);
        SceneManager.LoadScene(3);
    }
    public void StageSelectThree()
    {
        //�X�e�[�W�R�̃V�[��������
        audio.PlayOneShot(SE);
        SceneManager.LoadScene(4);
    }
    public void ToTitle() 
    {
        audio.PlayOneShot(SE);
        SceneManager.LoadScene("Title");
    }
    public void ToApplicationQuit()
    {
        audio.PlayOneShot(SE);
        Application.Quit();
    }
}
