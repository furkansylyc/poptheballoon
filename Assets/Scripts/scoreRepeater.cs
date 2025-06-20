using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreRepeater : MonoBehaviour
{
   private popPink poppink;
    void Start()
    {     
        poppink = GameObject.FindObjectOfType<popPink>().GetComponent<popPink>();
    }

    // Update is called once per frame
    void Update()
    {
       poppink.scoreText.text = popPink.totalScore + "";
    }
}
