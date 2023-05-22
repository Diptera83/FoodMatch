using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BombRandom : MonoBehaviour
{
    float GezinenX;
    float GezinenY;
    int saniye;
    int saniye2;
    bool toplandi;
    GameObject g;
    // Start is called before the first frame update
    void Start()
    {
        saniye = (int)Time.time;
        saniye2 = (int)Time.time;
        saniye = saniye + 5;

    }
    public bool itmeyedevam;
    // Update is called once per frame
    void Update()
    {
        if ((int)Time.time >= saniye && !toplandi)
        {
            itmeyedevam = true;
            GameObject[] Bombs = GameObject.FindGameObjectsWithTag("bomb");
            if (Bombs.Count() > 0)
            {
                toplandi = true;
                int sira = new System.Random().Next(0, Bombs.Count());
                g = Bombs[sira];

                saniye = (int)Time.time;
                saniye = saniye + 7;

                saniye2 = (int)Time.time;
            }
            else
            {
                 
                    itmeyedevam = false;
               
            }


        }
        else
        {

            toplandi = false;
            itmeyedevam = false;
            GameObject[] Bombs = GameObject.FindGameObjectsWithTag("bomb");
            if (Bombs.Count() > 0)
            {
                for (int i = 0; i < Bombs.Length; i++)
                {
                    Bombs[i].GetComponent<CircleCollider2D>().enabled = true;
                }

            }
            else
            {
                itmeyedevam= false;
            }


        }


        if ((int)Time.time >= saniye2 && (int)Time.time <= saniye2 + 2 && itmeyedevam && GameObject.Find("GameObject").GetComponent<LevelControl>().Level>=10)
        {

            Gezinme();

        }

    }
    int rakam;
    private void Gezinme()
    {


        g.GetComponent<CircleCollider2D>().enabled = false;
        StartCoroutine(WaitAndTeleport());





    }

    IEnumerator WaitAndTeleport()
    {


        g.transform.Find("BOMB").transform.Find("Katman 1 kopyala 9").GetComponent<BombaKaybolma>().t1anime();
        yield return new WaitForSeconds(1); // 1 saniye bekle
        g.transform.position = new Vector3(new System.Random().Next(-2, 2), new System.Random().Next(-4, 2), 0);
        g.transform.Find("BOMB").transform.Find("Katman 1 kopyala 9").GetComponent<BombaKaybolma>().t2anime();


    }


}
