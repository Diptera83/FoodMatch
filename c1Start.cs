using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class c1Start : MonoBehaviour
{
   
    private void OnMouseDown()
    {
        PlayerPrefs.DeleteKey("SavedLevel");
        PlayerPrefs.SetInt("SavedLevel", 1);
        PlayerPrefs.Save();
        SceneManager.LoadScene("SampleScene");
    }
}
