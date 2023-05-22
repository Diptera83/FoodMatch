using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class DragBombActivate : MonoBehaviour
{
    public AudioClip PushButtonAudio1;
    public AudioClip PushButtonAudio2;
    public int TotalDragBomb;
    bool BombaDurumu;
    public bool DevamEdiyormu;
    int saniye;
    int baslamaZamani;

    int bitiszamani;
    private void Start()
    {
        DevamEdiyormu = false;
        GameObject.Find("BombCounter").GetComponent<TextMeshPro>().enabled = false;
        transform.Find("Particle System_2").GetComponent<ParticleSystem>().Stop();
        transform.Find("Particle System").GetComponent<ParticleSystem>().Stop();
    }

    private void Update()
    {
        saniye = (int)Time.time;
        BombaDurumu = BombaSuresi();
    }

    bool BombaSuresi()
    {

        if (bitiszamani - saniye > 0)
        {
            if (PlayerPrefs.GetString("Lan") == "En")
            {
                GameObject.Find("SP_Info_2").GetComponent<TextMeshPro>().text = "You Can Drag Bombs in " + (bitiszamani - saniye).ToString() + " Seconds.";

            }
            else
            {

                GameObject.Find("SP_Info_2").GetComponent<TextMeshPro>().text = "Bombalari " + (bitiszamani - saniye).ToString() + " Saniye Ýcerisinde Surukleyebilirsiniz.";
            }
            
            GameObject.Find("SP_Info_2").GetComponent<MeshRenderer>().enabled = true;
            if (bitiszamani - saniye < 2)
            {
                GameObject.Find("SP_Info_2").GetComponent<TextMeshPro>().color = Color.red;
            }
            else
            {
                GameObject.Find("SP_Info_2").GetComponent<TextMeshPro>().color = Color.white;
            }

            return true;
        }
        else
        {
            DevamEdiyormu = false;
            BombaDurumu = false;
            if (BombaDurumu==false)
            {
                GameObject.Find("SP_Info_2").GetComponent<TextMeshPro>().text = "";
            }
            GameObject[] Bombs = GameObject.FindGameObjectsWithTag("bomb");
            GameObject[] Bombs2 = GameObject.FindGameObjectsWithTag("speedball");
            for (int i = 0; i < Bombs.Length; i++)
            {
                Bombs[i].GetComponent<BombMove>().BombActivated = false;
            }
            for (int i = 0; i < Bombs2.Length; i++)
            {
                Bombs2[i].GetComponent<BombMove2>().BombActivated = false;
            }
            return false;
        }
    }

    void zamanlayici()
    {
        saniye = (int)Time.time;
        baslamaZamani = saniye;
        bitiszamani = baslamaZamani + 5;
    }


    public int Get_TotalDragBomb()
    {
        TotalDragBomb = PlayerPrefs.GetInt("DragBomb");
        return TotalDragBomb;
    }

    private void OnMouseDown()
    {

        transform.Find("Particle System").GetComponent<ParticleSystem>().Play();
        GameObject[] Bombs = GameObject.FindGameObjectsWithTag("bomb");
        GameObject[] Bombs2 = GameObject.FindGameObjectsWithTag("speedball");
        if (Get_TotalDragBomb() > 0 && !DevamEdiyormu && GameObject.Find("GameObject").GetComponent<oyun>().oyunbaslasin && Bombs.Count()+Bombs2.Count()>0)
        {
            zamanlayici();
            BombaDurumu = true;
            DevamEdiyormu = true;
            if (Bombs.Length > 0)
            {
                for (int i = 0; i < Bombs.Length; i++)
                {
                    Bombs[i].GetComponent<BombMove>().BombActivated = true;
                    Bombs[i].transform.Find("Drag_Bomb_Effect").GetComponent<ParticleSystem>().Play();
                }
            }
            if (Bombs2.Length > 0)
            {
                for (int i = 0; i < Bombs2.Length; i++)
                {
                    Bombs2[i].GetComponent<BombMove2>().BombActivated = true;
                    Bombs2[i].transform.Find("Drag_Bomb_Effect").GetComponent<ParticleSystem>().Play();
                }
            }

            transform.Find("Particle System_2").GetComponent<ParticleSystem>().Play();

            SetTotalDragBomb();
            transform.GetComponent<AudioSource>().clip = PushButtonAudio1;
            transform.GetComponent<AudioSource>().Play();
        }
        else
        {
            transform.GetComponent<AudioSource>().clip = PushButtonAudio2;
            transform.GetComponent<AudioSource>().Play();
            BombaDurumu = false;
            for (int i = 0; i < Bombs.Length; i++)
            {
                Bombs[i].GetComponent<BombMove>().BombActivated = false;
            }
            for (int i = 0; i < Bombs2.Length; i++)
            {
                Bombs2[i].GetComponent<BombMove>().BombActivated = false;
            }
            StartCoroutine(WaitandShowRed());
        }
        IEnumerator WaitandShowRed()
        {
            GameObject.Find("SW_Drag").GetComponent<TextMeshPro>().color = Color.red;
            yield return new WaitForSeconds(1); // 1 saniye bekle
            GameObject.Find("SW_Drag").GetComponent<TextMeshPro>().color = Color.white;
        }

    }

    void SetTotalDragBomb()
    {



        TotalDragBomb = TotalDragBomb - 1;
        PlayerPrefs.DeleteKey("DragBomb");
        PlayerPrefs.SetInt("DragBomb", TotalDragBomb);
        PlayerPrefs.Save();

        GameObject.Find("GameObject").GetComponent<LevelControl>().DragBomb = TotalDragBomb;
        GameObject.Find("Drag_Bombs_Count").GetComponent<TextMeshPro>().text = TotalDragBomb.ToString();
        GameObject.Find("SW_Drag").GetComponent<TextMeshPro>().text = TotalDragBomb.ToString();


    }



}


