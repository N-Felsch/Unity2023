using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]

public class NewBehaviourScript : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;
   
    private Collider colliderObj;
   
    private void Start()
    {
        colliderObj = GetComponent<Collider>();
        colliderObj.isTrigger = true;
    }
   
    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }
}
