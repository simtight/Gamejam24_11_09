using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{

    [SerializeField] private Collider2D m_player;
    [SerializeField] private CanvasGroup goalBackgroundImageCanvasGroup;
    [SerializeField] private Canvas goalCanvas;

    private float m_timer;
    private float fadeDuration = 1f;


    private bool clearFLG = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (clearFLG)
        {
            GoalPerformance();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(m_player == collision)
        {
            goalCanvas.gameObject.SetActive(true);
            clearFLG = true;
        }
    }

    private void GoalPerformance()
    {
        m_timer += Time.deltaTime;
        
        goalBackgroundImageCanvasGroup.alpha = m_timer / fadeDuration;

    }
}
