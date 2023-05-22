using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameinfoButton : MonoBehaviour
{
    private void OnMouseDown()
    {
        GameObject.Find("GameTutorial").transform.position=new Vector3(0.19f, 1.60f, 0f);
        GameObject.Find("RG_Normal").GetComponent<BoxCollider2D>().enabled = false;
        GameObject.Find("NG_Normal 1").GetComponent<BoxCollider2D>().enabled = false;
        GameObject.Find("main_star 1").GetComponent<BoxCollider2D>().enabled = false;
        GameObject.Find("mapicon").GetComponent<BoxCollider2D>().enabled = false;
        GameObject.Find("statsicon").GetComponent<BoxCollider2D>().enabled = false;
        if (!transform.GetComponent<AudioSource>().isPlaying)
        {
            transform.GetComponent<AudioSource>().Play();
        }
        GameObject.Find("perde").transform.position = new Vector3(-1.82f, 0.72f, 0);

    }
    private void Start()
    {
        transform.GetComponent<AudioSource>().Stop();
    }
}
