using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthAdd : MonoBehaviour
{
    
    public IntegerData healthPack;

    public void OnTriggerEnter(Collider other)
    {
        if (CompareTag("Player"))
        {
            healthPack = healthPack + 1;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
