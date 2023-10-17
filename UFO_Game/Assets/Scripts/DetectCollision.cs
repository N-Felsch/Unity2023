using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{

    public ScoreManager scoreManager; // Store reference to score manager
    
    public int scoreToGive;

    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); // Find ScoreManager game object and reference ScoreManager script component
    }

    private void OnTriggerEnter(Collider other) // Once trigger has been entered record collision in the argument variable "other"
    {
        scoreManager.IncreaseScore(scoreToGive); // Increase the score
        Destroy(gameObject); // Destroys this gameobject
        Destroy(other.gameObject); // Destroys the other game object it hits
    }

   void OnTriggerExit(Collider other)
    {
        Destroy(gameObject); // Destroy this gameobject
        Destroy(other.gameObject); // Destroy the other gameobject it hits
    }
}
