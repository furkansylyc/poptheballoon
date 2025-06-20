using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class popPink : MonoBehaviour
{
    public int scorePerBalloon = 10;
    public static int totalScore = 0;
    public Text scoreText;
    private void OnMouseDown()
    {
        Destroy(this.gameObject);
        totalScore += scorePerBalloon;

    }
    void Start()
    {

    }


    void Update()
    {
       
    }
}
