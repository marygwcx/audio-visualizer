using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float minMove = -2;
    public float maxMove = 2;
    private Vector3 origin;

    void Start()
    {
        origin = transform.localPosition;
    }

    void Update()
    {
        var move = Mathf.Lerp(minMove, maxMove, AudioAnalyzer.instance.average);
        transform.localPosition = origin +  Vector3.forward * move;
        transform.LookAt(transform.parent.position);
    }
}
