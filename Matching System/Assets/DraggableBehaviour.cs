using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class DraggableBehaviour : MonoBehaviour
{

    private Camera cameraObj;
    public bool draggable;
    void Start()
    {
        cameraObj = Camera.main;
    }

    public IEnumerator OnMouseDown()
    {
        draggable = true;
        Debug.Log("Drag");

        while (draggable)
        {
            yield return new WaitForFixedUpdate();
        }
    }

    private void OnMouseUp()
    {
        draggable = false;
    }
}
