using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Object = UnityEngine.Object;

public class NewPowerUp : MonoBehaviour
{
    
    
    // If touching player, pickup item, print to console, and destroy game object
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Pickup();
        }

        void Pickup()
        {
            Debug.Log("Picked up Powerup");
            Destroy(gameObject);
        }
    }

    

    // How quickly does the Powerup move down the screen.
    public float powerupSpeed = 5.0f;
    void Update()
    {
        // Move PowerUp downward
        transform.Translate(Vector3.back * Time.deltaTime * powerupSpeed);
    }
}