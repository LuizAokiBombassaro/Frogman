using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public int TotalScore;
    public Text ScoreText;

    public static GameController instance;
    void Start()
    {
        instance = this;
    }

    public void UpdateScoreText()
    {
        ScoreText.text = TotalScore.ToString();
    }

}
