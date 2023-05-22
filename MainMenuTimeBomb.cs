using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainMenuTimeBomb : MonoBehaviour
{
    public int TotalStars;
    public int TotalTimeBomb;
    public AudioClip Plus_ok1;
    public AudioClip Plus_ok2;
    // Start is called before the first frame update
    void Start()
    {
        Get_TotalTimeBomb();
        Get_Total_Stars();
        GameObject.Find("Time_Bombs_Count").GetComponent<TextMeshPro>().text = TotalTimeBomb.ToString();
        GameObject.Find("TimeBomb_Plus").GetComponent<AudioSource>().Stop();
    }

    private void OnMouseDown()
    {
        SetTotalTimeBomb();
    }
    // Update is called once per frame
    void Update()
    {

    }
    public int Get_Total_Stars()
    {
        TotalStars = PlayerPrefs.GetInt("SavedStars");
        return TotalStars;

    }
    public int Get_TotalTimeBomb()
    {
        TotalTimeBomb = PlayerPrefs.GetInt("TimeBomb");
        return TotalTimeBomb;
    }
    public bool SetTotalTimeBomb()
    {
        Get_Total_Stars();
        if (TotalStars > 4)
        {
            TotalStars = TotalStars - 4;
            TotalTimeBomb = TotalTimeBomb + 1;
            PlayerPrefs.DeleteKey("TimeBomb");
            PlayerPrefs.SetInt("TimeBomb", TotalTimeBomb);
            PlayerPrefs.Save();
            PlayerPrefs.DeleteKey("SavedStars");
            PlayerPrefs.SetInt("SavedStars", TotalStars);
            PlayerPrefs.Save();
            GameObject.Find("Time_Bombs_Count").GetComponent<TextMeshPro>().text = TotalTimeBomb.ToString();

            GameObject.Find("totalStarsMainMenu").GetComponent<TextMeshPro>().text = TotalStars.ToString();
            GameObject.Find("collected_stars").GetComponent<TextMeshPro>().text = TotalStars.ToString();
            GameObject.Find("TimeBomb_Plus").GetComponent<AudioSource>().clip = Plus_ok1;
            GameObject.Find("TimeBomb_Plus").GetComponent<AudioSource>().Play();
            return true;
        }
        else
        {
            GameObject.Find("TimeBomb_Plus").GetComponent<AudioSource>().clip = Plus_ok2;
            GameObject.Find("TimeBomb_Plus").GetComponent<AudioSource>().Play();
            StartCoroutine(WaitandShowRed());
            return false;


        }

        IEnumerator WaitandShowRed()
        {
            GameObject.Find("collected_stars").GetComponent<TextMeshPro>().color = Color.red;
            yield return new WaitForSeconds(1); // 1 saniye bekle
            GameObject.Find("collected_stars").GetComponent<TextMeshPro>().color = Color.black;
        }
    }
}
