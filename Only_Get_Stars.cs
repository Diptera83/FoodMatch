using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Only_Get_Stars : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("totalStarsMainMenu").GetComponent<TextMeshPro>().text = Get_Total_Stars().ToString();
    }

    public int Get_Total_Stars()
    {
        return   PlayerPrefs.GetInt("SavedStars");
       

    }
}
