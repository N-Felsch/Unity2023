using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{

    public ScoreManager scoreManager; // Store reference to score manager
    
   public AudioClip explode; // Declaring the vars for player controller sound
   private AudioSource collisionAudio; 
    
    public int scoreToGive;

    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); // Find ScoreManager game object and reference ScoreManager script component
        collisionAudio = GetComponent<AudioSource>();
    }
    

    private void OnTriggerEnter(Collider other) // Once trigger has been entered record collision in the argument variable "other"
    {
        collisionAudio.PlayOneShot(explode, 1.0f);
        scoreManager.IncreaseScore(scoreToGive); // Increase the score
        Destroy(gameObject, 0.2f); // Destroys this gameobject
        Destroy(other.gameObject, 0.2f); // Destroys the other game object it hits
    }

   void OnTriggerExit(Collider other)
    {
        Destroy(gameObject, 0.2f); // Destroy this gameobject
        Destroy(other.gameObject, 0.2f); // Destroy the other gameobject it hits
    }
}
