using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EliminateBomb : MonoBehaviour
{
    public int TotalStars;
    public int TotalEliminateBomb;
    public AudioClip pushclip1;
    public AudioClip pushclip2;
    // Start is called before the first frame update
    void Start()
    {
        Get_Total_Stars();
        Get_TotalEliminateBomb();
        GameObject.Find("Bombs_Count").GetComponent<TextMeshPro>().text = TotalEliminateBomb.ToString();
        GameObject.Find("Bombs_Count_balon").GetComponent<TextMeshPro>().text = TotalEliminateBomb.ToString();
        transform.GetComponent<AudioSource>().Stop();
    }
    private void OnMouseDown()
    {
        SetTotalEliminateBomb();
    }
    public int Get_Total_Stars()
    {
        TotalStars = PlayerPrefs.GetInt("SavedStars");
        return TotalStars;

    }
    public int Get_TotalEliminateBomb()
    {
        TotalEliminateBomb = PlayerPrefs.GetInt("EliminateBomb");
        return TotalEliminateBomb;
    }

    public bool SetTotalEliminateBomb()
    {
        Get_Total_Stars();
        if (TotalStars > 5)
        {
            transform.GetComponent<AudioSource>().clip = pushclip1;
            transform.GetComponent<AudioSource>().Play();
            TotalStars = TotalStars - 5;
            TotalEliminateBomb = TotalEliminateBomb + 1;
            PlayerPrefs.DeleteKey("EliminateBomb");
            PlayerPrefs.SetInt("EliminateBomb", TotalEliminateBomb);
            PlayerPrefs.DeleteKey("SavedStars");
            PlayerPrefs.SetInt("SavedStars", TotalStars);
            PlayerPrefs.Save();
            GameObject.Find("Bombs_Count").GetComponent<TextMeshPro>().text = TotalEliminateBomb.ToString();
            GameObject.Find("Bombs_Count_balon").GetComponent<TextMeshPro>().text = TotalEliminateBomb.ToString();
            GameObject.Find("GameObject").GetComponent<LevelControl>().ToplamYildiz = TotalStars;
            GameObject.Find("GameObject").GetComponent<LevelControl>().EliminateBomb= TotalEliminateBomb;
            GameObject.Find("GameObject").GetComponent<oyun>().BombsCount = TotalEliminateBomb;
            GameObject.Find("collected_stars").GetComponent<TextMeshPro>().text = TotalStars.ToString();
            GameObject.Find("TotalStars").GetComponent<TextMeshPro>().text = TotalStars.ToString();
            return true;
        }
        else
        {
            //transform.GetComponent<AudioSource>().clip = pushclip2;
            //transform.GetComponent<AudioSource>().Play();
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
