using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class infoBack : MonoBehaviour
{
    private void OnMouseDown()
    {
        GameObject.Find("GameTutorial").transform.position=new Vector3(-11.44f, 1.60f, 0f);
        GameObject.Find("RG_Normal").GetComponent<BoxCollider2D>().enabled = true;
        GameObject.Find("NG_Normal 1").GetComponent<BoxCollider2D>().enabled = true;
        GameObject.Find("main_star 1").GetComponent<BoxCollider2D>().enabled = true;
        GameObject.Find("mapicon").GetComponent<BoxCollider2D>().enabled = true;
        GameObject.Find("statsicon").GetComponent<BoxCollider2D>().enabled = true;
        if (!transform.GetComponent<AudioSource>().isPlaying)
        {
            transform.GetComponent<AudioSource>().Play();
        }
        GameObject.Find("perde").transform.position = new Vector3(0, 20.42f, 0);
    }
    private void Start()
    {
        transform.GetComponent<AudioSource>().Stop();

        if (PlayerPrefs.GetString("Lan") == "En")
        {

            transform.GetComponent<TextMeshPro>().text = "BACK";
        }
        else
        {
            transform.GetComponent<TextMeshPro>().text = "GERI";
        }
    }
}
