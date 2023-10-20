using System;
using UnityEngine;
using UnityEngine.Events;
public class EventBehaviour : MonoBehaviour
{
    public UnityEvent tiggerEnterEvent;

    private void OnTriggerEnter(Collider other)
    {
        tiggerEnterEvent.Invoke();
    }
}
