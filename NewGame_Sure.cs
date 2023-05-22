using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGame_Sure : MonoBehaviour
{
    private void OnMouseDown()
    {
        PlayerPrefs.DeleteKey("SavedLevel");
        PlayerPrefs.DeleteKey("SavedScore");
        PlayerPrefs.DeleteKey("SavedStars");
        PlayerPrefs.SetInt("SavedLevel", 1);
        PlayerPrefs.SetInt("SavedScore", 0);
        PlayerPrefs.SetInt("SavedStars", 20);
        PlayerPrefs.Save();
        transform.Find("Particle System").GetComponent<ParticleSystem>().Play();
        if (!transform.GetComponent<AudioSource>().isPlaying)
        {
            transform.GetComponent<AudioSource>().Play();
        }
        GameObject.Find("perde").transform.position = new Vector3(-1.82f, 0.72f, 0);
        StartCoroutine(WaitAndWork());
    }

    IEnumerator WaitAndWork()
    {
        yield return new WaitForSeconds(1); // 1 saniye bekle
        transform.Find("Particle System").GetComponent<ParticleSystem>().Stop();
       
        SceneManager.LoadScene("SampleScene");

    }
    private void Start()
    {
     
        transform.GetComponent<AudioSource>().Stop();

    }

}