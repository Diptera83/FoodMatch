using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuteEffects : MonoBehaviour
{
    public int isMute;
    public Sprite SoundOn;
    public Sprite SoundOff;
    // Start is called before the first frame update
    void Start()
    {
       
        if (PlayerPrefs.HasKey("MuteEffects"))
        {
            isMute = PlayerPrefs.GetInt("MuteEffects");

            if (isMute == 1)
            {
                AudioListener.pause = true;
                GameObject.Find("soundon").GetComponent<SpriteRenderer>().sprite = SoundOff;

            }
            else
            {
                AudioListener.pause = false ;
                GameObject.Find("soundon").GetComponent<SpriteRenderer>().sprite = SoundOn;

            }
        }
        else
        {
            AudioListener.pause = false;
            GameObject.Find("soundon").GetComponent<SpriteRenderer>().sprite = SoundOn;
            PlayerPrefs.SetInt("MuteEffects", 0);
            PlayerPrefs.Save();
            isMute = 0;
        }
    }

    private void OnMouseDown()
    {
        isMute = PlayerPrefs.GetInt("MuteEffects");
        if (isMute==0)
        {
            AudioListener.pause = true;
            GameObject.Find("soundon").GetComponent<SpriteRenderer>().sprite = SoundOff;
            PlayerPrefs.DeleteKey("MuteEffects");
            PlayerPrefs.SetInt("MuteEffects", 1);
            PlayerPrefs.Save();
            transform.GetComponent<AudioSource>().Play();

        }
        else
        {
            AudioListener.pause = false;
            GameObject.Find("soundon").GetComponent<SpriteRenderer>().sprite = SoundOn;
            PlayerPrefs.DeleteKey("MuteEffects");
            PlayerPrefs.SetInt("MuteEffects", 0);
            PlayerPrefs.Save();
            transform.GetComponent<AudioSource>().Play();

        }
    }


}
