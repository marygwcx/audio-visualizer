using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class SineSound : MonoBehaviour
{

    [Range(100, 20000)]
    public float frequency; //Hz

    [Range(0, 1)]
    public float amplitude = 0.5f;

    public float clipLenght = 5f; //sec

    public int sampleRate = 44100;

    void Start()
    {
        //calculate total samples
        var sampleCount = (int)(sampleRate * clipLenght);

        //create audio clip
        var audioClip = AudioClip.Create("Sine Wave", sampleCount, 1, sampleRate, false);

        //sine
        var samples = new float[sampleCount];
        var increment = 2 * Mathf.PI / sampleRate;
        var phase = 0f;

        for(int i = 0; i < sampleCount; i++)
        {
            samples[i] = amplitude * Mathf.Sin(phase * frequency);
            phase += increment;
        }

        //audio clip
        audioClip.SetData(samples, 0);

        //play
        var audioSource = GetComponent<AudioSource>();
        audioSource.clip = audioClip;
        audioSource.loop = true;
        audioSource.Play();
    }

    
}
