using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class press_directly_on_the_bomb : MonoBehaviour
{
    int TotalEliminateBomb;
    private void Start()
    {
        GameObject.Find("press_direkt_on_bomb").GetComponent<TextMeshPro>().text = "";
        //GameObject.Find("Bombs_Count").GetComponent<TextMeshPro>().text = Get_TotalEliminateBomb().ToString();

    }
    private void OnMouseDown()
    {

        if (PlayerPrefs.GetString("Lan") == "En")
        {

            GameObject.Find("press_direkt_on_bomb").GetComponent<TextMeshPro>().text = "press directly on the bomb";
        }
        else
        {

            GameObject.Find("press_direkt_on_bomb").GetComponent<TextMeshPro>().text = "DIREK BOMBANIN UZERINE BASIN";
        }


        StartCoroutine(WaitAndInfo());

    }

    IEnumerator WaitAndInfo()
    {
        yield return new WaitForSeconds(3); // 3 saniye bekle
        GameObject.Find("press_direkt_on_bomb").GetComponent<TextMeshPro>().text = "";
    }
    public int Get_TotalEliminateBomb()
    {
        TotalEliminateBomb = PlayerPrefs.GetInt("EliminateBomb");
        return TotalEliminateBomb;
    }
}
