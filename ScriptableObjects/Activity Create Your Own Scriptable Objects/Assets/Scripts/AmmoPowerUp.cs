using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPowerUp : MonoBehaviour
{
    public IntData ammoValue;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Add ammo to the players weapon
            AddAmmo(other.gameObject);
            
            // Destroy the power-up game object
            Destroy(gameObject);
        }
    }

    private void AddAmmo(GameObject player)
    {
        // Retrieve the players weapon component (e.g. WeaponController script)
        WeaponController weaponController = player.GetComponent<WeaponController>();
        
        // Check if the player has a weapon component
        if (weaponController != null)
        {
            // Add the ammo Value to the players current ammo count
            weaponController.AddAmmo(ammoValue.Value);
        }
    }
}
