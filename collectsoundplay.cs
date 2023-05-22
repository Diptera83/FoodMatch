using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectsoundplay : MonoBehaviour
{

    public AudioClip collect1;
    public AudioClip collect2;
    public AudioClip collect3;
    public AudioClip collect4;
    public AudioClip collect5;

    private void Start()
    {
        transform.GetComponent<AudioSource>().Stop();
    }

    public void PlayCollectSound()
    {
        switch (new System.Random().Next(1, 6))
        {
            case 1: transform.GetComponent<AudioSource>().clip = collect1; break;
            case 2: transform.GetComponent<AudioSource>().clip = collect5; break;
            case 3: transform.GetComponent<AudioSource>().clip = collect3; break;
            case 4: transform.GetComponent<AudioSource>().clip = collect4; break;
            case 5: transform.GetComponent<AudioSource>().clip = collect2; break;

            default:
                break;
        }
        if (!transform.GetComponent<AudioSource>().isPlaying)
        {
            transform.GetComponent<AudioSource>().Play();
        }
    }
}
