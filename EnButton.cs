using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnButton : MonoBehaviour
{
    private void OnMouseDown()
    {
        GameObject.Find("arkaduvar (1)").GetComponent<Language>().eNMenu();
        GameObject.Find("en").GetComponent<AudioSource>().Play();
        PlayerPrefs.DeleteKey("Lan");
        PlayerPrefs.SetString("Lan", "En");
        PlayerPrefs.Save();
        GameObject.Find("arkaduvar (1)").GetComponent<Language>().AppLan = "En";
        GameObject.Find("turcerceve").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.Find("encerceve").GetComponent<SpriteRenderer>().enabled = true;

    }
}
