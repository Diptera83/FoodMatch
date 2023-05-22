using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rateus1 : MonoBehaviour
{
    private void OnMouseDown()
    {

        Application.OpenURL("https://play.google.com/store/apps/details?id=com.Diptera.FoodMatch");

        PlayerPrefs.DeleteKey("isRate");
            PlayerPrefs.SetInt("isRate", 1);
            PlayerPrefs.Save();
        
        GameObject.Find("rateus").transform.position = new Vector3(13.96f, -1.4944f, 0);
        
    }
}
