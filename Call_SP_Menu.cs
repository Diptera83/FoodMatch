using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Call_SP_Menu : MonoBehaviour
{
    private void OnMouseDown()
    {
        GameObject.Find("SP_Menu (1)").GetComponent<PauseMenuOpenClose>().MoveTo(new Vector3(-0.1f, 13.85f, -0.92f));
        GameObject.Find("RG_Normal").GetComponent<BoxCollider2D>().enabled = false;
        GameObject.Find("NG_Normal 1").GetComponent<BoxCollider2D>().enabled = false;
        GameObject.Find("main_star 1").GetComponent<BoxCollider2D>().enabled = false;
        GameObject.Find("mapicon").GetComponent<BoxCollider2D>().enabled = false;
        GameObject.Find("statsicon").GetComponent<BoxCollider2D>().enabled = false;
        GameObject.Find("perde").transform.position = new Vector3(-1.82f, 0.72f, 0);
        if (!transform.GetComponent<AudioSource>().isPlaying)
        {
            transform.GetComponent<AudioSource>().Play();
        }
        
    }
    private void Start()
    {
        transform.GetComponent<AudioSource>().Stop();
    }
}
