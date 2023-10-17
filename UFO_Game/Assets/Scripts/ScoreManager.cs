using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Text Mesh Pro name space added to access the Unity libraries for UI

public class ScoreManager : MonoBehaviour
{
    public int score; // Keeps track of our score 

    public TextMeshProUGUI scoreText; // Visual text element to be modified 

    public void IncreaseScore(int amount) // When called this increments the score by desired amount in score variable
    {
        score += amount;
        UpdateScoreText();
    }

    public void DecreaseScore(int amount) // When called this decrements the score by desired amount in score variable
    {
        score -= amount;
        UpdateScoreText();
    }
    public void UpdateScoreText() // This method updates the score in the HUD UI text
    {
        scoreText.text = "Score: "+ score;
    }
}
