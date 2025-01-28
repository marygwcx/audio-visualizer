using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public Vector3 direction = Vector3.forward;
    public float minSpeed = 0;
    public float maxSpeed = 1000;
    void Update()
    {
        var speed = Mathf.Lerp(minSpeed, maxSpeed, AudioAnalyzer.instance.average);
        transform.Rotate(direction * speed * Time.deltaTime);
    }
}
