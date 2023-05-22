using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class New_Game_Button : MonoBehaviour
{

    public Sprite NewSprite;

    private void OnMouseDown()
    {
        GameObject.Find("perde").transform.position = new Vector3(-1.82f, 0.72f, 0);
        transform.Find("Particle System").GetComponent<ParticleSystem>().Play();
        transform.GetComponent<SpriteRenderer>().sprite = NewSprite;
        if (!transform.GetComponent<AudioSource>().isPlaying)
        {
            transform.GetComponent<AudioSource>().Play();
        }


        if (PlayerPrefs.GetInt("SavedLevel") <= 1)
        {
            PlayerPrefs.DeleteKey("SavedLevel");
            PlayerPrefs.DeleteKey("SavedScore");
            PlayerPrefs.DeleteKey("SavedStars");
            PlayerPrefs.SetInt("SavedLevel", 1);
            PlayerPrefs.SetInt("SavedScore", 0);
            PlayerPrefs.SetInt("SavedStars", 20);
            PlayerPrefs.Save();
            StartCoroutine(WaitAndWorkFirstGame());
        }
        else
        {
            GameObject.Find("AreYouSureForNewGame").GetComponent<AreYouSureCall>().MoveTo(new Vector3(-0.14f, 11.17f, 0));
            StartCoroutine(WaitAndWork());
        }



    }

    private void Start()
    {
        transform.Find("Particle System").GetComponent<ParticleSystem>().Stop();
        transform.GetComponent<AudioSource>().Stop();
    }


    IEnumerator WaitAndWork()
    {
        yield return new WaitForSeconds(3); // 1 saniye bekle
        transform.Find("Particle System").GetComponent<ParticleSystem>().Stop();

    }

    IEnumerator WaitAndWorkFirstGame()
    {
        yield return new WaitForSeconds(1); // 1 saniye bekle
        transform.Find("Particle System").GetComponent<ParticleSystem>().Stop();
        SceneManager.LoadScene("SampleScene");
    }
}
