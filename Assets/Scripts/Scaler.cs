using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    
    void Update()
    {
        //transform.localScale = AudioAnalyzer.instance.average * new Vector3(1, 1, 1);
        transform.localScale = AudioAnalyzer.instance.average * Vector3.one * 10;
    }
}
