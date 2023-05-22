using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainMenuTransformerBomb : MonoBehaviour
{
    public int TotalStars;
    public int TotalTransformerBomb;
    public AudioClip Plus_ok1;
    public AudioClip Plus_ok2;
    // Start is called before the first frame update
    void Start()
    {
        Get_TotalTransformerBomb();
        Get_Total_Stars();
        GameObject.Find("Transformer_Bombs_Count").GetComponent<TextMeshPro>().text = TotalTransformerBomb.ToString();
        GameObject.Find("TransformerBomb_Plus").GetComponent<AudioSource>().Stop();
    }

    private void OnMouseDown()
    {
        SetTotalTransformerBomb();
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
            TotalStars = TotalStars - 10;
            TotalTransformerBomb = TotalTransformerBomb + 1;
            PlayerPrefs.DeleteKey("TurnBomb");
            PlayerPrefs.SetInt("TurnBomb", TotalTransformerBomb);
            PlayerPrefs.Save();
            PlayerPrefs.DeleteKey("SavedStars");
            PlayerPrefs.SetInt("SavedStars", TotalStars);
            PlayerPrefs.Save();
            GameObject.Find("Transformer_Bombs_Count").GetComponent<TextMeshPro>().text = TotalTransformerBomb.ToString();

            GameObject.Find("totalStarsMainMenu").GetComponent<TextMeshPro>().text = TotalStars.ToString();
            GameObject.Find("collected_stars").GetComponent<TextMeshPro>().text = TotalStars.ToString();
            GameObject.Find("TransformerBomb_Plus").GetComponent<AudioSource>().clip = Plus_ok1;
            GameObject.Find("TransformerBomb_Plus").GetComponent<AudioSource>().Play();
            return true;
        }
        else
        {
            GameObject.Find("TransformerBomb_Plus").GetComponent<AudioSource>().clip = Plus_ok2;
            GameObject.Find("TransformerBomb_Plus").GetComponent<AudioSource>().Play();
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
