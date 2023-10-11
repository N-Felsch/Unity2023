using System;
using UnityEngine;

public class BlinkEffect : MonoBehaviour
{
    public Color startColor = Color.magenta;
    public Color endColor = Color.blue;
    [Range(0, 10)]
    public float speed = 1f;

    Renderer ren;

    void Awake()
    {
        ren = GetComponent<Renderer>();
    }

    private void Update()
    {
        ren.material.color = Color.Lerp(startColor, endColor, Mathf.PingPong(Time.time * speed, 1));
    }
}
