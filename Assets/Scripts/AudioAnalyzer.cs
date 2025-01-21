using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class AudioAnalyzer : MonoBehaviour
{
    public static AudioAnalyzer instance; //singleton
    public int sampleRate = 44100;
    public float average;

    private AudioSource audioSource;
    private float[] samples;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        samples = new float[sampleRate];
    }

    void Update()
    {
       if(audioSource.isPlaying)
        {
            audioSource.clip.GetData(samples, audioSource.timeSamples);
            //for (int i = 0;  i < samples.Length; i++)
            //{
            //average = (samples[i] + samples[i + 1]) / i;
            //   average += samples[i];
            // }
            average = 0;
           foreach(var s  in samples)
            {
                average += Mathf.Abs(s); //abs - convert all values to positive numbers
            }
            average = average/samples.Length;
            
        }
    }
    private void Awake()
    {
        //this script is the variable that will communicate with other scripts
        if(instance == null)
        {
            instance = this;
        }
    }

}
