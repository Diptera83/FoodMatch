using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainMenuEliminateBomb_Plus : MonoBehaviour
{
    public int TotalStars;
    public int TotalEliminateBomb;
    public AudioClip Plus_ok1;
    public AudioClip Plus_ok2;
    // Start is called before the first frame update
    void Start()
    {
        Get_TotalEliminateBomb();
        Get_Total_Stars();
        GameObject.Find("Eliminate_Bombs_Count").GetComponent<TextMeshPro>().text = TotalEliminateBomb.ToString();
        GameObject.Find("EliminateBomb_Plus").GetComponent<AudioSource>().Stop();
    }

    private void OnMouseDown()
    {
        SetTotalEliminateBomb();
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
            TotalStars = TotalStars - 5;
            TotalEliminateBomb = TotalEliminateBomb + 1;
            PlayerPrefs.DeleteKey("EliminateBomb");
            PlayerPrefs.SetInt("EliminateBomb", TotalEliminateBomb);
            PlayerPrefs.Save();
            PlayerPrefs.DeleteKey("SavedStars");
            PlayerPrefs.SetInt("SavedStars", TotalStars);
            PlayerPrefs.Save();
            GameObject.Find("Eliminate_Bombs_Count").GetComponent<TextMeshPro>().text = TotalEliminateBomb.ToString();

            GameObject.Find("totalStarsMainMenu").GetComponent<TextMeshPro>().text = TotalStars.ToString();
            GameObject.Find("collected_stars").GetComponent<TextMeshPro>().text = TotalStars.ToString();
            GameObject.Find("EliminateBomb_Plus").GetComponent<AudioSource>().clip = Plus_ok1;
            GameObject.Find("EliminateBomb_Plus").GetComponent<AudioSource>().Play();
            return true;
        }
        else
        {
            GameObject.Find("EliminateBomb_Plus").GetComponent<AudioSource>().clip = Plus_ok2;
            GameObject.Find("EliminateBomb_Plus").GetComponent<AudioSource>().Play();
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
