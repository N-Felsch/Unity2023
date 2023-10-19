using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetectSound : MonoBehaviour
{
    public AudioClip explode; // Declaring the vars for player controller sound
    private AudioSource collisionAudio; 

    void Start()
    {
        collisionAudio = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other) // Once trigger has been entered record collision in the argument variable "other"
    {
        collisionAudio.PlayOneShot(explode, 1.0f);
    }
}
