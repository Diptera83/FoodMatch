using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicOn : MonoBehaviour
{
    public int isMute;
    public Sprite SoundOn;
    public Sprite SoundOff;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("Music"))
        {
            isMute = PlayerPrefs.GetInt("Music");

            if (isMute == 1)
            {
                GameObject.Find("arkaduvar (1)").GetComponent<AudioSource>().Stop();
                GameObject.Find("musicon").GetComponent<SpriteRenderer>().sprite = SoundOff;

            }
            else
            {
                GameObject.Find("arkaduvar (1)").GetComponent<AudioSource>().Play();
                GameObject.Find("musicon").GetComponent<SpriteRenderer>().sprite = SoundOn;

            }
        }
        else
        {
            GameObject.Find("arkaduvar (1)").GetComponent<AudioSource>().Play();
            GameObject.Find("musicon").GetComponent<SpriteRenderer>().sprite = SoundOn;
            PlayerPrefs.SetInt("Music", 0);
            PlayerPrefs.Save();
            isMute = 0;
        }
    }

    private void OnMouseDown()
    {
        isMute = PlayerPrefs.GetInt("Music");
        if (isMute == 0)
        {
            GameObject.Find("arkaduvar (1)").GetComponent<AudioSource>().Stop();
            GameObject.Find("musicon").GetComponent<SpriteRenderer>().sprite = SoundOff;
            PlayerPrefs.DeleteKey("Music");
            PlayerPrefs.SetInt("Music", 1);
            PlayerPrefs.Save();
           

        }
        else
        {
            GameObject.Find("arkaduvar (1)").GetComponent<AudioSource>().Play();
            GameObject.Find("musicon").GetComponent<SpriteRenderer>().sprite = SoundOn;
            PlayerPrefs.DeleteKey("Music");
            PlayerPrefs.SetInt("Music", 0);
            PlayerPrefs.Save();
            

        }
    }
}
