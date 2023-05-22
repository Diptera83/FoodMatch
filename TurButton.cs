using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurButton : MonoBehaviour
{
    public Sprite TurkBayrak;
    public Sprite ingilizbayrak;
    private void OnMouseDown()
    {
        if (GameObject.Find("tur").GetComponent<SpriteRenderer>().sprite==TurkBayrak)
        {
            transform.Find("en").GetComponent<SpriteRenderer>().sprite = TurkBayrak;
            GameObject.Find("arkaduvar (1)").GetComponent<Language>().eNMenu();
            GameObject.Find("tur").GetComponent<AudioSource>().Play();
            PlayerPrefs.DeleteKey("Lan");
            PlayerPrefs.SetString("Lan", "En");
            PlayerPrefs.Save();
            GameObject.Find("arkaduvar (1)").GetComponent<Language>().AppLan = "En";
            //GameObject.Find("encerceve").GetComponent<SpriteRenderer>().enabled = false;
            //GameObject.Find("turcerceve").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.Find("tur").GetComponent<SpriteRenderer>().sprite = ingilizbayrak;
        }
        else
        {
            transform.Find("en").GetComponent<SpriteRenderer>().sprite = ingilizbayrak;
            GameObject.Find("arkaduvar (1)").GetComponent<Language>().TurMenu();
            GameObject.Find("tur").GetComponent<AudioSource>().Play();
            PlayerPrefs.DeleteKey("Lan");
            PlayerPrefs.SetString("Lan", "Tur");
            PlayerPrefs.Save();
            GameObject.Find("arkaduvar (1)").GetComponent<Language>().AppLan = "Tur";
            //GameObject.Find("encerceve").GetComponent<SpriteRenderer>().enabled = false;
            //GameObject.Find("turcerceve").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.Find("tur").GetComponent<SpriteRenderer>().sprite = TurkBayrak;
        }


    }
}
