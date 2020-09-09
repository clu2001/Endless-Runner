using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class ScoreManager : MonoBehaviour
{
    public int score;
    public Text scoreDisplay;

    // Update is called once per frame
    void Update()
    {
        scoreDisplay.text = score.ToString();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Obstacle"))
        {
            // increase score
            score++;
            Debug.Log(score);
        }
    }

    
}
