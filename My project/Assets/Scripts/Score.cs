using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public int ballValue;
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        UpdateScore();
    }
    void OnCollisionEnter2D()
    {
        score += ballValue;
        UpdateScore();
    }

    // Update is called once per frame
    void UpdateScore()
    {
        scoreText.text = "Баллы:\n" + score;
    }
}
