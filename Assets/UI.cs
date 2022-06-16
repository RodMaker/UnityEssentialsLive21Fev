using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    // away score
    public TextMeshProUGUI scoreAwayText;

    public void SetScoreText (int score)
    {
        scoreText.text = score.ToString();
    }

    // away score
    public void SetScoreAwayText (int scoreAway)
    {
        scoreAwayText.text = scoreAway.ToString();
    }
}
