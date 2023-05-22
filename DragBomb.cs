using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DragBomb : MonoBehaviour
{
    public int TotalStars;
    public int TotalDragBomb;
    public AudioClip pushclip1;
    public AudioClip pushclip2;
    // Start is called before the first frame update
    void Start()
    {
    //    PlayerPrefs.DeleteKey("SavedStars");
    //    PlayerPrefs.SetInt("SavedStars", 1000);
    //    PlayerPrefs.Save();
        Get_TotalDragBomb();
        Get_Total_Stars();
        GameObject.Find("Drag_Bombs_Count").GetComponent<TextMeshPro>().text = TotalDragBomb.ToString();
        GameObject.Find("SW_Drag").GetComponent<TextMeshPro>().text = TotalDragBomb.ToString();
        transform.GetComponent<AudioSource>().Stop();
    }

    private void OnMouseDown()
    {
        SetTotalDragBomb();
    }
    public int Get_Total_Stars()
    {
        TotalStars = PlayerPrefs.GetInt("SavedStars");
        return TotalStars;

    }
    public int Get_TotalDragBomb()
    {
        TotalDragBomb = PlayerPrefs.GetInt("DragBomb");
        return TotalDragBomb;
    }

    public bool SetTotalDragBomb()
    {
        Get_Total_Stars();
        if (TotalStars > 3)
        {
            transform.GetComponent<AudioSource>().clip = pushclip1;
            transform.GetComponent<AudioSource>().Play();
            TotalStars = TotalStars - 3;
            TotalDragBomb = TotalDragBomb + 1;
            PlayerPrefs.DeleteKey("DragBomb");
            PlayerPrefs.SetInt("DragBomb", TotalDragBomb);
            PlayerPrefs.Save();
            PlayerPrefs.DeleteKey("SavedStars");
            PlayerPrefs.SetInt("SavedStars", TotalStars);
            PlayerPrefs.Save();
            GameObject.Find("Drag_Bombs_Count").GetComponent<TextMeshPro>().text = TotalDragBomb.ToString();
            GameObject.Find("SW_Drag").GetComponent<TextMeshPro>().text = TotalDragBomb.ToString();
            GameObject.Find("GameObject").GetComponent<LevelControl>().ToplamYildiz = TotalStars;
            GameObject.Find("GameObject").GetComponent<LevelControl>().DragBomb = TotalDragBomb;
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
