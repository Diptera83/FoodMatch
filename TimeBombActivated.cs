using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeBombActivated : MonoBehaviour
{
    int BaslamaZamani;
    int TotalTimeBomb;
    bool DevamEdiyormu;
    public AudioClip PushButtonAudio1;
    public AudioClip PushButtonAudio2;
    // Start is called before the first frame update
    void Start()
    {
        transform.GetComponent<AudioSource>().Stop();
        transform.Find("Particle System").GetComponent<ParticleSystem>().Stop();
        transform.Find("Particle System_2").GetComponent<ParticleSystem>().Stop();
        transform.Find("snowflake").GetComponent<SpriteRenderer>().enabled = false;
        transform.Find("snowflake_2").GetComponent<SpriteRenderer>().enabled = false;
        transform.Find("snowflake_3").GetComponent<SpriteRenderer>().enabled = false;
        transform.Find("PS_Snow").GetComponent<ParticleSystem>().Stop();
    }

    // Update is called once per frame
    void Update()
    {
        TimeController();
    }

    void SureBaslat()
    {
        BaslamaZamani = (int)Time.time;
        DevamEdiyormu = true;
    }

    bool TimeController()
    {
        if (BaslamaZamani + 5 - (int)Time.time > 0)
        {
            
            GameObject.Find("GameObject").GetComponent<oyun>().OyunDurdu = true;
            if (PlayerPrefs.GetString("Lan") == "En")
            {
                GameObject.Find("SP_Info").GetComponent<TextMeshPro>().text = "The Match Is Pause In " + ((int)BaslamaZamani + 5 - (int)Time.time).ToString() + " Seconds.";

            }
            else
            {

                GameObject.Find("SP_Info").GetComponent<TextMeshPro>().text = "Oyun " + ((int)BaslamaZamani + 5 - (int)Time.time).ToString() + " Saniyeligine Donduruldu.";
            }
            
            if (BaslamaZamani + 5 - (int)Time.time < 2)
            {
                GameObject.Find("SP_Info").GetComponent<TextMeshPro>().color = Color.red;
            }
            else
            {
                GameObject.Find("SP_Info").GetComponent<TextMeshPro>().color = Color.white;
            }
            return true;
        }
        else
        {
            if (!GameObject.Find("GameObject").GetComponent<oyun>().OyunDurdu)
            {
                GameObject.Find("SP_Info").GetComponent<TextMeshPro>().text = "";
            }
            GameObject.Find("GameObject").GetComponent<oyun>().OyunDurdu = false;
            
            transform.Find("Particle System").GetComponent<ParticleSystem>().Stop();
            transform.Find("Particle System_2").GetComponent<ParticleSystem>().Stop();
            transform.Find("snowflake").GetComponent<SpriteRenderer>().enabled = false;
            transform.Find("snowflake_2").GetComponent<SpriteRenderer>().enabled = false;
            transform.Find("snowflake_3").GetComponent<SpriteRenderer>().enabled = false;
            DevamEdiyormu = false;
            return false;
        }
    }

    private void OnMouseDown()
    {
        transform.Find("Particle System").GetComponent<ParticleSystem>().Play();
        Get_TotalTimeBomb();
        if (TotalTimeBomb > 0 && GameObject.Find("GameObject").GetComponent<oyun>().oyunbaslasin && !DevamEdiyormu)
        {
            transform.Find("snowflake").GetComponent<SpriteRenderer>().enabled = true;
            transform.Find("snowflake_2").GetComponent<SpriteRenderer>().enabled = true;
            transform.Find("snowflake_3").GetComponent<SpriteRenderer>().enabled = true;
            transform.Find("PS_Snow").GetComponent<ParticleSystem>().Play();
            transform.GetComponent<AudioSource>().clip = PushButtonAudio1;
            transform.GetComponent<AudioSource>().Play();
            transform.Find("Particle System_2").GetComponent<ParticleSystem>().Play();
            SureBaslat();
            SetTotalTimeBomb();
        }
        else
        {
            transform.GetComponent<AudioSource>().clip = PushButtonAudio2;
            transform.GetComponent<AudioSource>().Play();
            StartCoroutine(WaitandShowRed());
        }

        IEnumerator WaitandShowRed()
        {
            GameObject.Find("SW_Time").GetComponent<TextMeshPro>().color = Color.red;
            yield return new WaitForSeconds(1); // 1 saniye bekle
            GameObject.Find("SW_Time").GetComponent<TextMeshPro>().color = Color.white;
        }

    }

    void SetTotalTimeBomb()
    {

        TotalTimeBomb = TotalTimeBomb - 1;
        PlayerPrefs.DeleteKey("TimeBomb");
        PlayerPrefs.SetInt("TimeBomb", TotalTimeBomb);
        PlayerPrefs.Save();
        GameObject.Find("GameObject").GetComponent<LevelControl>().TimeBomb = TotalTimeBomb;
        GameObject.Find("Time_Bombs_Count").GetComponent<TextMeshPro>().text = TotalTimeBomb.ToString();
        GameObject.Find("SW_Time").GetComponent<TextMeshPro>().text = TotalTimeBomb.ToString();

    }

    public int Get_TotalTimeBomb()
    {
        TotalTimeBomb = PlayerPrefs.GetInt("TimeBomb");
        return TotalTimeBomb;
    }
}
