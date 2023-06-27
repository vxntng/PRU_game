using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    // Start is called before the first frame update
    private Text scoreText;

    private void Awake()
    {
        scoreText = GetComponent<Text>();
    }

    public void UpdateScore(int score)
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
