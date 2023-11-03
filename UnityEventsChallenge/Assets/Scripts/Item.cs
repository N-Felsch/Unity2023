using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Item : MonoBehaviour
{
   public UnityEvent pickupItem;
   
   public void OnTriggerEnter(Collision other)
   {
      pickupItem.Invoke();
   }
}
