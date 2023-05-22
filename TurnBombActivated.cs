using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TurnBombActivated : MonoBehaviour
{
    public AudioClip PushButtonAudio1;
    public AudioClip PushButtonAudio2;
    int TotalTurnBomb;
    bool DevamEdiyormu;
    float Xpoz;
    float YPoz;
    public GameObject Cookie;
    public GameObject Egg;
    public GameObject Donut;
    public GameObject Orange;
    public GameObject Melon;
    List<GameObject> Objelerim;
    int randomTetromino;
    // Start is called before the first frame update
    void Start()
    {
        transform.Find("Particle System").GetComponent<ParticleSystem>().Stop();
        Objelerim = new List<GameObject>();
        Objelerim.Add(Cookie);
        Objelerim.Add(Egg);
        Objelerim.Add(Donut);
        Objelerim.Add(Melon);
        Objelerim.Add(Orange);
    }

  

    public int Get_TotalTurnBomb()
    {
        TotalTurnBomb = PlayerPrefs.GetInt("TurnBomb");
        return TotalTurnBomb;
    }
    void SetTotalTurnBomb()
    {

        TotalTurnBomb = TotalTurnBomb - 1;
        PlayerPrefs.DeleteKey("TurnBomb");
        PlayerPrefs.SetInt("TurnBomb", TotalTurnBomb);
        PlayerPrefs.Save();
        GameObject.Find("GameObject").GetComponent<LevelControl>().TurnBomb= TotalTurnBomb;
        GameObject.Find("Transformer_Bombs_Count").GetComponent<TextMeshPro>().text = TotalTurnBomb.ToString();
        GameObject.Find("SW_Turn").GetComponent<TextMeshPro>().text = TotalTurnBomb.ToString();

    }
    private void OnMouseDown()
    {

        transform.Find("Particle System").GetComponent<ParticleSystem>().Play();
        GameObject[] Bombs = GameObject.FindGameObjectsWithTag("bomb");
        if (Get_TotalTurnBomb() > 0 && !DevamEdiyormu && GameObject.Find("GameObject").GetComponent<oyun>().oyunbaslasin)
        {
            transform.GetComponent<AudioSource>().clip = PushButtonAudio1;
            transform.GetComponent<AudioSource>().Play();
            DevamEdiyormu = true;
            randomTetromino = new System.Random().Next(0, 5);
            if (Bombs.Length > 0)
            {
                for (int i = 0; i < Bombs.Length; i++)
                {
                    Xpoz = Bombs[i].transform.position.x;
                    YPoz = Bombs[i].transform.position.y;
                    GameObject.Find("GameObject").GetComponent<Stats>().ExBomb++;
                    Destroy(Bombs[i]);

                    Instantiate(Objelerim[randomTetromino], new Vector2(Xpoz, YPoz), Quaternion.identity);
                }
                SetTotalTurnBomb();
            }
            else
            {
                StartCoroutine(WaitandShowRed());
            }


            

            
        }
        else
        {

            transform.GetComponent<AudioSource>().clip = PushButtonAudio2;
            transform.GetComponent<AudioSource>().Play();
            for (int i = 0; i < Bombs.Length; i++)
            {
                Bombs[i].GetComponent<BombMove>().BombActivated = false;
            }
            StartCoroutine(WaitandShowRed());
        }
        IEnumerator WaitandShowRed()
        {
            GameObject.Find("SW_Turn").GetComponent<TextMeshPro>().color = Color.red;
            yield return new WaitForSeconds(1); // 1 saniye bekle
            GameObject.Find("SW_Turn").GetComponent<TextMeshPro>().color = Color.white;
        }

    }
}
