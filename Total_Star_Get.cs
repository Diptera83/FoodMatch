using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Total_Star_Get : MonoBehaviour
{
    public int TotalStars;
    public int TotalDragBomb;
    public int TotalTimeBomb;
    public int TotalTransformerBomb;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("collected_stars").GetComponent<TextMeshPro>().text = Get_Total_Stars().ToString();
        
        GameObject.Find("Time_Bombs_Count").GetComponent<TextMeshPro>().text = Get_TotalTimeBomb().ToString();
        GameObject.Find("Transformer_Bombs_Count").GetComponent<TextMeshPro>().text = Get_TotalTransformerBomb().ToString();
    }

   
    public int Get_Total_Stars()
    {
        TotalStars= PlayerPrefs.GetInt("SavedStars");
        return TotalStars;

    }
    
    public int Get_TotalTimeBomb() 
    {
        TotalTimeBomb = PlayerPrefs.GetInt("TimeBomb");
        return TotalTimeBomb;
    }
    public int Get_TotalTransformerBomb() 
    {
        TotalTransformerBomb = PlayerPrefs.GetInt("TurnBomb");
        return TotalTransformerBomb;
    }

    public bool SetTotalStars()
    {
        try
        {
            PlayerPrefs.DeleteKey("SavedStars");
            PlayerPrefs.SetInt("SavedStars", TotalStars);
            PlayerPrefs.Save();
            return true;
        }
        catch (System.Exception)
        {

            return false;
        }
      
    }
  

}
