using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class BombCrash : MonoBehaviour
{
    public AudioClip foodexp1;
    public AudioClip foodexp2;
    public AudioClip foodexp3;
    public AudioClip foodexp4;
    public AudioClip foodexp5;
    public AudioClip foodexp6;
    public AudioClip foodexp7;
    

    public void crashaudio()
    {
        switch (new System.Random().Next(1, 8))
        {
            case 1: transform.GetComponent<AudioSource>().clip = foodexp1; break;
            case 2: transform.GetComponent<AudioSource>().clip = foodexp2; break;
            case 3: transform.GetComponent<AudioSource>().clip = foodexp3; break;
            case 4: transform.GetComponent<AudioSource>().clip = foodexp4; break;
            case 5: transform.GetComponent<AudioSource>().clip = foodexp5; break;
            case 6: transform.GetComponent<AudioSource>().clip = foodexp1; break;
            case 7: transform.GetComponent<AudioSource>().clip = foodexp2; break;
           
            default:
                break;
        }

        transform.GetComponent<AudioSource>().Play();
    }
 
}
