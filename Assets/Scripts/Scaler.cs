using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    public float minScale = 0.5f;
    public float maxScale = 1.5f;
    
    void Update()
    {
        //transform.localScale = AudioAnalyzer.instance.average * new Vector3(1, 1, 1);
        var scale = Mathf.Lerp(minScale, maxScale, AudioAnalyzer.instance.average);
        transform.localScale = scale * Vector3.one;
    }
}
