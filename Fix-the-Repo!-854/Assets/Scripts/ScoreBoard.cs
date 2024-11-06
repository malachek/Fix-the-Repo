using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreBoard : MonoBehaviour
{
    [SerializeField] TextMeshPro scoreText;
    private int score = 0;

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
    }

    public void Reset()
    {
        score = 0;
        scoreText.text = score.ToString("D2"); //formats score to 2 digits: 00, 01,...,10, 11

    }
}
