using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class c6Start : MonoBehaviour
{
    private void OnMouseDown()
    {

        PlayerPrefs.DeleteKey("SavedLevel");
        PlayerPrefs.SetInt("SavedLevel", 50);
        PlayerPrefs.Save();
        SceneManager.LoadScene("SampleScene");
    }
}
