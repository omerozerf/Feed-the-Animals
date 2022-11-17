using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{

    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private Image leftH;
    [SerializeField] private Image midH;
    [SerializeField] private Image rightH;
    
    
    private static int score = 0;
    private static int life = 3;

    private void Update()
    {
        UpdateScoreText();
        ControlHealthUI();
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }

    public static void WinScore()
    {
        score++;
    }

    public static void LoseLife()
    {
        life--;
    }

    private void ControlHealthUI()
    {
        if (life == 2)
        {
            rightH.color = Color.black;
        }

        if (life == 1)
        {
            midH.color = Color.black;
        }

        if (life == 0)
        {
            leftH.color = Color.black;
        }
    }
    
    

}
