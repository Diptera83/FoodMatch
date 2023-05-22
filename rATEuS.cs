using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rATEuS : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.DeleteKey("isRate");
        //PlayerPrefs.SetInt("isRate", 0);
        //PlayerPrefs.Save();
        if (PlayerPrefs.HasKey("isRate"))
        {
            if (PlayerPrefs.GetInt("isRate") == 0 && PlayerPrefs.GetInt("SavedLevel") >= 3)
            {
                transform.position = new Vector3(0.14f, -1.4944f, 0);
            }
            else
            {

                transform.position = new Vector3(13.96f, -1.4944f, 0);
            }
        }
        else
        {
            PlayerPrefs.SetInt("isRate",0);
            PlayerPrefs.Save();
            transform.position = new Vector3(0.14f, -1.4944f, 0);
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
