using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class counter : MonoBehaviour
{
    public int zaman;
    public Sprite S1;
    public Sprite S2;
    public Sprite S3;
    public Sprite S4;
  public  bool finished;
    
    // Start is called before the first frame update
    void Start()
    {
  

        finished = false;
        transform.Find("parla").GetComponent<ParticleSystem>().Stop();
        transform.Find("parla2").GetComponent<ParticleSystem>().Stop();
        transform.Find("parla3").GetComponent<ParticleSystem>().Stop();
        zaman = (int)Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        MenuButtonActive();
        if (finished == false)
        {
            

            if ((int)Time.time == zaman)
            {
                GameObject.Find("You_Lost").GetComponent<MainStarAnimes>().You_Lost_Music_is_Played = false;
                transform.GetComponent<SpriteRenderer>().enabled = true;
                transform.GetComponent<SpriteRenderer>().sprite = S3;
                if (!transform.Find("parla").GetComponent<ParticleSystem>().isPlaying)
                {
                    transform.Find("parla").GetComponent<ParticleSystem>().Play();
                    transform.Find("parla").GetComponent<AudioSource>().Play();
                }

            }
            else if ((int)Time.time == zaman + 1)
            {
                transform.Find("parla").GetComponent<ParticleSystem>().Stop();
                if (!transform.Find("parla2").GetComponent<ParticleSystem>().isPlaying)
                {
                    transform.Find("parla2").GetComponent<ParticleSystem>().Play();
                    transform.Find("parla2").GetComponent<AudioSource>().Play();
                }
                transform.GetComponent<SpriteRenderer>().sprite = S2;
            }
            else if ((int)Time.time == zaman + 2)
            {
                transform.Find("parla2").GetComponent<ParticleSystem>().Stop();
                if (!transform.Find("parla3").GetComponent<ParticleSystem>().isPlaying)
                {
                    transform.Find("parla3").GetComponent<ParticleSystem>().Play();
                    transform.Find("parla3").GetComponent<AudioSource>().Play();
                }
                transform.GetComponent<SpriteRenderer>().sprite = S1;

            }
            else if ((int)Time.time == zaman + 3)
            {
                transform.Find("parla3").GetComponent<ParticleSystem>().Stop();
                if (!transform.Find("parla4").GetComponent<ParticleSystem>().isPlaying)
                {
                    transform.Find("parla4").GetComponent<ParticleSystem>().Play();
                    transform.Find("parla4").GetComponent<AudioSource>().Play();
                }
                transform.GetComponent<SpriteRenderer>().sprite = S4;

            }
            else if ((int)Time.time == zaman + 4)
            {
                transform.Find("parla4").GetComponent<ParticleSystem>().Stop();
                //transform.Find("parla").GetComponent<ParticleSystem>().Stop();
                transform.GetComponent<SpriteRenderer>().sprite = null;
                finished = true;
            }
          
        }

    }

    public void MenuButtonActive()
    {
        if (!finished)
        {
            
            GameObject.Find("Burger_Menu").GetComponent<BoxCollider2D>().enabled = false;
            GameObject.Find("Burger_Menu").GetComponent<SpriteRenderer>().enabled = false;
            GameObject.Find("Burger_Menu").transform.position = new Vector3(10.55f, 4.57f, 0);
        }
        else
        {
            if (!GameObject.Find("GameObject").GetComponent<LevelControl>().levelgecildimi && !GameObject.Find("GameObject").GetComponent<LevelControl>().levelkaybedildi)
            {
                GameObject.Find("Burger_Menu").transform.position = new Vector3(2.4f, 4.57f, 0);
                GameObject.Find("Burger_Menu").GetComponent<BoxCollider2D>().enabled = true;
                GameObject.Find("Burger_Menu").GetComponent<SpriteRenderer>().enabled = true;
            }
           
            else
            {
                GameObject.Find("Burger_Menu").GetComponent<BoxCollider2D>().enabled = false;
                GameObject.Find("Burger_Menu").GetComponent<SpriteRenderer>().enabled = false;
                GameObject.Find("Burger_Menu").transform.position = new Vector3(10.55f, 4.57f, 0);
            }
            
        }
    }
}
