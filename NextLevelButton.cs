using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelButton : MonoBehaviour
{
    public int []ReklamLevel;
    private void Start()
    {
        ReklamLevel = new int[] { 1, 3, 5, 7, 9, 11, 13, 15, 17,19, 21, 23, 25, 27, 29, 31, 33, 35, 37,39,41,43,45,47,49,51,53,55,57,59,61,63,65,67,69,71,73,75,77,79,81,83,85,87,89,91,93,95,97,99 };
        //transform.GetComponent<AudioSource>().Stop();
    }
    private void OnMouseDown()
    {
        GameObject.Find("klaketicon").GetComponent<SpriteRenderer>().enabled = true;
        GameObject.Find("perde").transform.position = new Vector3(0.206f, 25.83f, 0);

        //Reklam Girer
        if (ReklamLevel.Contains(PlayerPrefs.GetInt("SavedLevel")))
        {
            GameObject.Find("musicon").GetComponent<AudioSource>().Stop();
            GameObject.Find("musicon").GetComponent<Background_Sound>().isADS = true;
           GameObject.Find("Main Camera").GetComponent<GecisReklami>().ShowAd();
            
        }
        else
        {
            GameObject.Find("counter").GetComponent<counter>().GetComponent<SpriteRenderer>().enabled = true;
            GameObject.Find("musicon").GetComponent<Background_Sound>().isADS = false;
            string currentSceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentSceneName);
        }
       
        
    }

    public void SonrakiSeviyeyeGec()
    {
        GameObject.Find("musicon").GetComponent<Background_Sound>().isADS = false;
        GameObject.Find("counter").GetComponent<counter>().GetComponent<SpriteRenderer>().enabled = true;
        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);

    }




}
