using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public class circleSpawner : MonoBehaviour
{
    public GameObject particle;
    public int count = 5;
    public float spawnRadius = 3;

    void Start()
    {
        var angle = 360f / count;
        for(int i=0; i <count; i++)
        {
            var rad = angle * i * Mathf.Deg2Rad;
            var x = Mathf.Cos(rad) * spawnRadius;
            var y = Mathf.Sin(rad) * spawnRadius;
            Instantiate(particle, new Vector3(x, y), Quaternion.identity, transform);
            
        }
        
    }

    
}
