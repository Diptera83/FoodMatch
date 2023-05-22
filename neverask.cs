using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class neverask : MonoBehaviour
{
    private void OnMouseDown()
    {

        PlayerPrefs.DeleteKey("isRate");
        PlayerPrefs.SetInt("isRate", 1);
        PlayerPrefs.Save();
        GameObject.Find("rateus").transform.position = new Vector3(13.96f, -1.4944f, 0);



    }
}
