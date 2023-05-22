using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TransformerBomb : MonoBehaviour
{
    public int TotalStars;
    public int TotalTransformerBomb;
    public AudioClip pushclip1;
    public AudioClip pushclip2;
    // Start is called before the first frame update
    void Start()
    {
        Get_Total_Stars();
        Get_TotalTransformerBomb();
        GameObject.Find("Transformer_Bombs_Count").GetComponent<TextMeshPro>().text = TotalTransformerBomb.ToString();
        GameObject.Find("SW_Turn").GetComponent<TextMeshPro>().text = TotalTransformerBomb.ToString();
        transform.GetComponent<AudioSource>().Stop();
    }
    private void OnMouseDown()
    {
        SetTotalTransformerBomb();
    }
    public int Get_Total_Stars()
    {
        TotalStars = PlayerPrefs.GetInt("SavedStars");
        return TotalStars;

    }
    public int Get_TotalTransformerBomb()
    {
        TotalTransformerBomb = PlayerPrefs.GetInt("TurnBomb");
        return TotalTransformerBomb;
    }

    public bool SetTotalTransformerBomb()
    {
        Get_Total_Stars();
        if (TotalStars > 10)
        {
            transform.GetComponent<AudioSource>().clip = pushclip1;
            transform.GetComponent<AudioSource>().Play();
            TotalStars = TotalStars - 10;
            TotalTransformerBomb = TotalTransformerBomb + 1;
            PlayerPrefs.DeleteKey("TurnBomb");
            PlayerPrefs.SetInt("TurnBomb", TotalTransformerBomb);
            PlayerPrefs.Save();
            PlayerPrefs.DeleteKey("SavedStars");
            PlayerPrefs.SetInt("SavedStars", TotalStars);
            PlayerPrefs.Save();
            GameObject.Find("Transformer_Bombs_Count").GetComponent<TextMeshPro>().text = TotalTransformerBomb.ToString();
            GameObject.Find("SW_Turn").GetComponent<TextMeshPro>().text = TotalTransformerBomb.ToString();
            GameObject.Find("GameObject").GetComponent<LevelControl>().ToplamYildiz = TotalStars;
            GameObject.Find("GameObject").GetComponent<LevelControl>().TurnBomb = TotalTransformerBomb;
            GameObject.Find("collected_stars").GetComponent<TextMeshPro>().text = TotalStars.ToString();
            GameObject.Find("TotalStars").GetComponent<TextMeshPro>().text = TotalStars.ToString();
            return true;
        }
        else
        {
            transform.GetComponent<AudioSource>().clip = pushclip2;
            transform.GetComponent<AudioSource>().Play();
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
