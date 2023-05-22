using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BackGroundEngine : MonoBehaviour
{
    int Level;
   public Sprite Chapter1Background;
   public Sprite Chapter2Background;
    public Sprite Chapter3Background;
    public Sprite Chapter4Background;
    public Sprite KorkulukChapter2;
    public Sprite MasaChapter1;
    public Sprite TahtaKasa3;
    public Sprite Rope4;
    private void Start()
    {
        //LevelMarker();
    }
    //public void LevelMarker()
    //{
        

    //    Level = PlayerPrefs.GetInt("SavedLevel");
    //    if (Level > 0 && Level < 10)
    //    {
    //        transform.GetComponent<SpriteRenderer>().sprite = Chapter1Background;
    //        transform.rotation = Quaternion.Euler(0, 0, -90);
    //        GameObject.Find("5atman 10 kopyala 5").GetComponent<SpriteRenderer>().enabled = true ;
    //        GameObject.Find("kuyruk").GetComponent<SpriteRenderer>().enabled = true;
    //        GameObject.Find("t1").GetComponent<SpriteRenderer>().enabled = true;
    //        GameObject.Find("t2").GetComponent<SpriteRenderer>().enabled = true;
    //        GameObject.Find("t3").GetComponent<SpriteRenderer>().enabled = true;
    //        GameObject.Find("Katman 3 kopyala 10").GetComponent<SpriteRenderer>().enabled = true;
    //        GameObject.Find("Katman 3 kopyala 10").transform.rotation = Quaternion.Euler(0, 0, 0);
    //        GameObject.Find("Katman 3 kopyala 10").transform.localScale = new Vector3(1, 1, 1);
    //        GameObject.Find("Table").transform.position = new Vector3(0,-5.63f,0.43f);
    //        GameObject.Find("Katman 3 kopyala 10").GetComponent<SpriteRenderer>().sprite = MasaChapter1 ;
            
    //        GameObject.Find("Calendar").transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
    //        GameObject.Find("Calendar").transform.position = new Vector3(1.87f, -2.76f, 0.03f);

    //    }
    //    else if (Level >= 10 && Level < 20)
    //    {

    //        transform.GetComponent<SpriteRenderer>().sprite = Chapter2Background;
    //        transform.rotation = Quaternion.Euler(0, 0, 0);
    //        transform.localScale = new Vector3(0.8038f, 0.751096f, 1);
    //        transform.position = new Vector3(-0.1076f, 0.2357f, 0);
    //        GameObject.Find("5atman 10 kopyala 5").GetComponent<SpriteRenderer>().enabled = false;
    //        GameObject.Find("kuyruk").GetComponent<SpriteRenderer>().enabled = false;
    //        GameObject.Find("t1").GetComponent<SpriteRenderer>().enabled = false;
    //        GameObject.Find("t2").GetComponent<SpriteRenderer>().enabled = false;
    //        GameObject.Find("t3").GetComponent<SpriteRenderer>().enabled = false;
            
    //        GameObject.Find("Katman 3 kopyala 10").GetComponent<SpriteRenderer>().sprite = KorkulukChapter2;
    //        GameObject.Find("Katman 3 kopyala 10").transform.rotation = Quaternion.Euler(0, 0, 0);
    //        GameObject.Find("Katman 3 kopyala 10").transform.localScale = new Vector3(0.59985f, 0.4647633f, 1);
    //        GameObject.Find("Katman 3 kopyala 10").transform.position = new Vector3(0.03f, -4.88f, 0);

    //        GameObject.Find("Calendar").transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
    //        GameObject.Find("Calendar").transform.position = new Vector3(1.87f, -4.49f, -0.03f);
    //    }
    //    else if (Level >= 20 && Level < 30)
    //    {

    //        transform.GetComponent<SpriteRenderer>().sprite = Chapter3Background;
    //        transform.rotation = Quaternion.Euler(0, 0, 0);
    //        transform.localScale = new Vector3(1, 1, 1);
    //        transform.position = new Vector3(-0.52f, 3.2f, 0);
    //        GameObject.Find("5atman 10 kopyala 5").GetComponent<SpriteRenderer>().enabled = false;
    //        GameObject.Find("kuyruk").GetComponent<SpriteRenderer>().enabled = false;
    //        GameObject.Find("t1").GetComponent<SpriteRenderer>().enabled = false;
    //        GameObject.Find("t2").GetComponent<SpriteRenderer>().enabled = false;
    //        GameObject.Find("t3").GetComponent<SpriteRenderer>().enabled = false;
    //        //GameObject.Find("Katman 3 kopyala 10").GetComponent<SpriteRenderer>().enabled = false;
    //        GameObject.Find("Katman 3 kopyala 10").GetComponent<SpriteRenderer>().sprite = TahtaKasa3;
    //        GameObject.Find("Katman 3 kopyala 10").transform.rotation = Quaternion.Euler(0, 0, 0);
    //        GameObject.Find("Katman 3 kopyala 10").transform.localScale = new Vector3(0.5872f, 0.6289f, 1);
    //        GameObject.Find("Katman 3 kopyala 10").transform.position = new Vector3(0, -5.63f, 0.43f);

    //        GameObject.Find("Calendar").transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
    //        GameObject.Find("Calendar").transform.position = new Vector3(1.87f, -4.49f, -0.03f);
    //    }
    //    else if (Level >= 30 && Level < 40)
    //    {

    //        transform.GetComponent<SpriteRenderer>().sprite = Chapter4Background;
    //        transform.rotation = Quaternion.Euler(0, 0,0);
    //        transform.localScale = new Vector3(1f, 1f, 1f);
    //        transform.position = new Vector3(0.37f, -0.18f, 0);
    //        GameObject.Find("5atman 10 kopyala 5").GetComponent<SpriteRenderer>().enabled = false;
    //        GameObject.Find("kuyruk").GetComponent<SpriteRenderer>().enabled = false;
    //        GameObject.Find("t1").GetComponent<SpriteRenderer>().enabled = false;
    //        GameObject.Find("t2").GetComponent<SpriteRenderer>().enabled = false;
    //        GameObject.Find("t3").GetComponent<SpriteRenderer>().enabled = false;
    //        //GameObject.Find("Katman 3 kopyala 10").GetComponent<SpriteRenderer>().enabled = false;
    //        GameObject.Find("Katman 3 kopyala 10").GetComponent<SpriteRenderer>().sprite = Rope4;
    //        GameObject.Find("Katman 3 kopyala 10").transform.rotation = Quaternion.Euler(0, 0, 0);
    //        GameObject.Find("Katman 3 kopyala 10").transform.localScale = new Vector3(0.6f, 0.5659f, 1);
    //        GameObject.Find("Katman 3 kopyala 10").transform.position = new Vector3(-0.0034f, -5.462f, 0);

    //        GameObject.Find("Calendar").transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
    //        GameObject.Find("Calendar").transform.position = new Vector3(1.87f, -4.49f, -0.03f);
    //    }
    //    if (Level > 40 && Level < 50)
    //    {
    //        transform.GetComponent<SpriteRenderer>().sprite = Chapter1Background;
    //        GameObject.Find("5atman 10 kopyala 5").GetComponent<SpriteRenderer>().enabled = true;
    //        GameObject.Find("kuyruk").GetComponent<SpriteRenderer>().enabled = true;
    //        GameObject.Find("t1").GetComponent<SpriteRenderer>().enabled = true;
    //        GameObject.Find("t2").GetComponent<SpriteRenderer>().enabled = true;
    //        GameObject.Find("t3").GetComponent<SpriteRenderer>().enabled = true;
    //        GameObject.Find("Katman 3 kopyala 10").GetComponent<SpriteRenderer>().enabled = true;
    //        GameObject.Find("Katman 3 kopyala 10").transform.rotation = Quaternion.Euler(0, 0, 0);
    //        GameObject.Find("Katman 3 kopyala 10").transform.localScale = new Vector3(1, 1, 1);
    //        GameObject.Find("Table").transform.position = new Vector3(0, -5.63f, 0.43f);
    //        GameObject.Find("Katman 3 kopyala 10").GetComponent<SpriteRenderer>().sprite = MasaChapter1;

    //        GameObject.Find("Calendar").transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
    //        GameObject.Find("Calendar").transform.position = new Vector3(1.87f, -2.76f, 0.03f);

    //    }
    //    else
    //    {
    //        transform.GetComponent<SpriteRenderer>().sprite = Chapter1Background;
    //        GameObject.Find("5atman 10 kopyala 5").GetComponent<SpriteRenderer>().enabled = true;
    //        GameObject.Find("kuyruk").GetComponent<SpriteRenderer>().enabled = true;
    //        GameObject.Find("t1").GetComponent<SpriteRenderer>().enabled = true;
    //        GameObject.Find("t2").GetComponent<SpriteRenderer>().enabled = true;
    //        GameObject.Find("t3").GetComponent<SpriteRenderer>().enabled = true;
    //        GameObject.Find("Katman 3 kopyala 10").GetComponent<SpriteRenderer>().enabled = true;
    //        GameObject.Find("Katman 3 kopyala 10").transform.rotation = Quaternion.Euler(0, 0, 0);
    //        GameObject.Find("Katman 3 kopyala 10").transform.localScale = new Vector3(1, 1, 1);
    //        GameObject.Find("Table").transform.position = new Vector3(0, -5.63f, 0.43f);
    //        GameObject.Find("Katman 3 kopyala 10").GetComponent<SpriteRenderer>().sprite = MasaChapter1;

    //        GameObject.Find("Calendar").transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
    //        GameObject.Find("Calendar").transform.position = new Vector3(1.87f, -2.76f, 0.03f);

    //    }

    //}


}
