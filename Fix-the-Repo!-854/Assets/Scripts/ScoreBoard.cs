using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreBoard : MonoBehaviour
{
    [SerializeField] TextMeshPro scoreText;
    [SerializeField] TextMeshPro highScoreText;

    public int score { get; private set; }
    private int highScore = 0;

    void Start()
    {
        score = 0;
        scoreText.text = "00";
    }

    // Update is called once per frame
    public void Score()
    {
        score++;
        scoreText.text = score.ToString("D2"); //formats score to 2 digits: 00, 01,...,10, 11

        if (score > highScore)
        {
            highScore = score;
            highScoreText.text = highScore.ToString("D2");
        }
    }

    public void GameOver()
    {        
        score = 0;
        scoreText.text = score.ToString("D2"); //formats score to 2 digits: 00, 01,...,10, 11

    }
}
