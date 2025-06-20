using UnityEngine;
using UnityEngine.UI;

public class Puan : MonoBehaviour
{ 
    public int scorePerBalloon = 10; 
    public static int totalScore = 0;
    public Text scoreText;  
    void OnDestroy()
    {     
        totalScore += scorePerBalloon;       
        UpdateScoreText();
    }  
    void UpdateScoreText()
    {
        scoreText.text = "Score: " + totalScore.ToString();
    }
}
