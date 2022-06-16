using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public int score;
    // away score
    public int scoreAway;
    public UI ui;
    public void AddScore(int amount)
    {
        score += amount;

        // adds the values to the canvas
        ui.SetScoreText(score);
    }

    // away score
    public void AddScoreAway(int amountAway)
    {
        scoreAway += amountAway;
        ui.SetScoreAwayText(scoreAway);
    }
}
