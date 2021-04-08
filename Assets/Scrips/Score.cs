using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    Text scoreText;
    int score = 0;
    private void Start()
    {
        scoreText = GetComponent<Text>();
    }

    public void addToScore()
    {
        score += 1;
        scoreText.text = "Score: " + score.ToString();
    }
    public void restartScore()
    {
        score = 0;
    }

}
