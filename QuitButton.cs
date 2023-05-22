using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitButton : MonoBehaviour
{
   
    public Sprite NewSprite;
    private void OnMouseDown()
    {
        transform.Find("Particle System").GetComponent<ParticleSystem>().Play();
        if (!transform.GetComponent<AudioSource>().isPlaying)
        {
            transform.GetComponent<AudioSource>().Play();
        }
        transform.GetComponent<SpriteRenderer>().sprite = NewSprite;
        StartCoroutine(WaitAndWork());
    }

    private void Start()
    {
        transform.Find("Particle System").GetComponent<ParticleSystem>().Stop();
        transform.GetComponent<AudioSource>().Stop();
    }


    IEnumerator WaitAndWork()
    {
        yield return new WaitForSeconds(1); // 1 saniye bekle

        Application.Quit();

    }
}
