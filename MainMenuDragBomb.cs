using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainMenuDragBomb : MonoBehaviour
{
    public int TotalStars;
    public int TotalDragBomb;
    public AudioClip Plus_ok1;
    public AudioClip Plus_ok2;
    // Start is called before the first frame update
    void Start()
    {
        Get_TotalDragBomb();
        Get_Total_Stars();
        GameObject.Find("Drag_Bombs_Count").GetComponent<TextMeshPro>().text = TotalDragBomb.ToString();
        
        GameObject.Find("DragBomb_Plus").GetComponent<AudioSource>().Stop();
    }

    private void OnMouseDown()
    {
        SetTotalDragBomb();
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
            TotalStars = TotalStars - 3;
            TotalDragBomb = TotalDragBomb + 1;
            PlayerPrefs.DeleteKey("DragBomb");
            PlayerPrefs.SetInt("DragBomb", TotalDragBomb);
            PlayerPrefs.Save();
            PlayerPrefs.DeleteKey("SavedStars");
            PlayerPrefs.SetInt("SavedStars", TotalStars);
            PlayerPrefs.Save();
            GameObject.Find("Drag_Bombs_Count").GetComponent<TextMeshPro>().text = TotalDragBomb.ToString();
    
            GameObject.Find("totalStarsMainMenu").GetComponent<TextMeshPro>().text = TotalStars.ToString();
            GameObject.Find("collected_stars").GetComponent<TextMeshPro>().text = TotalStars.ToString();
            GameObject.Find("DragBomb_Plus").GetComponent<AudioSource>().clip = Plus_ok1;
            GameObject.Find("DragBomb_Plus").GetComponent<AudioSource>().Play();
            return true;
        }
        else
        {
            GameObject.Find("DragBomb_Plus").GetComponent<AudioSource>().clip = Plus_ok2;
            GameObject.Find("DragBomb_Plus").GetComponent<AudioSource>().Play();
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
