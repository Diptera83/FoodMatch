using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class rESUME_gAME_bUTTON : MonoBehaviour
{
    public GameObject BuObje;
    public Sprite NewSprite;
    private void OnMouseDown()
    {
        transform.Find("Particle System").GetComponent<ParticleSystem>().Play();
        BuObje.GetComponent<SpriteRenderer>().sprite = NewSprite;
        if (!transform.GetComponent<AudioSource>().isPlaying)
        {
            transform.GetComponent<AudioSource>().Play();
        }
        StartCoroutine(WaitAndWork());
    }

    private void Start()
    {
        transform.Find("Particle System").GetComponent<ParticleSystem>().Stop();
        transform.GetComponent<AudioSource>().Stop();
        if (PlayerPrefs.GetInt("SavedLevel")<=1)
        {
            GameObject.Find("RG_Normal").GetComponent<SpriteRenderer>().enabled = false;
            GameObject.Find("RG_Normal").GetComponent<BoxCollider2D>().enabled = false;
        }
        else
        {
            GameObject.Find("RG_Normal").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.Find("RG_Normal").GetComponent<BoxCollider2D>().enabled = true;
        }
    }


    IEnumerator WaitAndWork()
    {

       
      

        yield return new WaitForSeconds(1); // 1 saniye bekle

        
        SceneManager.LoadScene("SampleScene");


    }
}
