using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookieRising : MonoBehaviour
{
    public AudioClip r0;
    public AudioClip r1;
    public AudioClip r2;
    public AudioClip r3;
    public AudioClip r4;
    public AudioClip r5;
    public AudioClip r6;
    public AudioClip r7;
    public AudioClip r8;
    public AudioClip r9;

    List<AudioClip> rList;
    // Start is called before the first frame update
    void Start()
    {
        transform.GetComponent<AudioSource>().Stop();
        rList = new List<AudioClip>();
        rList.Add(r0);
        rList.Add(r1);
        rList.Add(r2);
        rList.Add(r3);
        rList.Add(r4);
        rList.Add(r5);
        rList.Add(r6);
        rList.Add(r7);
        rList.Add(r8);
        rList.Add(r9);
     

    }

    public void PlayRList(int number)
    {

        transform.GetComponent<AudioSource>().clip = rList[number];
        
        transform.GetComponent<AudioSource>().Play();
    }
}
