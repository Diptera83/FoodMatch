using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class c3Start : MonoBehaviour
{
    private void OnMouseDown()
    {

        PlayerPrefs.DeleteKey("SavedLevel");
        PlayerPrefs.SetInt("SavedLevel", 20);
        PlayerPrefs.Save();
        SceneManager.LoadScene("SampleScene");
    }
}
