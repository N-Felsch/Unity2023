using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public AudioClip shoot; // Declaring the vars for player controller sound
    private AudioSource playerAudio;
    
    public float horizontalInput;

    public float speed = 25;

    public float xRange = 25;

    public Transform blaster;

    public GameObject lazerBolt;

    public GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>(); // Reference Game Manager script on GameManager object
        playerAudio = GetComponent<AudioSource>();
    }
    

    // Update is called once per frame
    void Update()
    {
        // Set HorizontalInput to recieve values from keyboard
        horizontalInput = Input.GetAxis("Horizontal");

        // Moves Player left and right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        // Keep player within boundary
        // Left side wall
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        // Keep player within boundary
        // Right side wall
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        // If spacebar pressed, fire lazerbolt
        if (Input.GetKeyDown(KeyCode.Space) && gameManager.isGameOver == false) // Second condition gameManager.isGameOver prevents the player from shooting after isGameOver becomes true
        {
            // Create lazerbolt at the blaster transform position maintaining the objects rotation
            Instantiate(lazerBolt, blaster.transform.position, lazerBolt.transform.rotation);
            playerAudio.PlayOneShot(shoot, 1.0f);
        }
       
    }

    /* For Future use
    // Trying to print the items in the list to the console
    public List<string> itemList = new List<string>();
        public void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("PowerUp"))
            {
                itemList.Add("Power up Collected");
            }

            for (int i = 0; i < itemList.Count; i++)
            {
                Debug.Log(itemList);
            }
        } */
    
    }
    

