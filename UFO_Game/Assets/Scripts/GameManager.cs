using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   public bool isGameOver;

   private GameObject gameOverText;

   void Awake()
   {
      Time.timeScale = 1;
      isGameOver = false;
   }

   public void Start()
   {
      gameOverText = GameObject.Find("GameOverText");
   }

   public void Update()
   {
      if (isGameOver)
      {
         EndGame(); // Start EndGame Method
      } 
      else
         gameOverText.gameObject.SetActive(false); // Keep UI Text Game Over hidden
   }

   public void EndGame()
   {
      gameOverText.gameObject.SetActive(true); // Make Game Over text appear
      Time.timeScale = 0; // Freeze time
   }
}
