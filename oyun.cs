using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Mathematics;
using UnityEngine;

public class oyun : MonoBehaviour
{
    public GameObject Obje;
    public int laugh;
    public GameObject Cookie;
    public GameObject Egg;
    public GameObject Donut;
    public GameObject Orange;
    public GameObject Melon;
    public GameObject Star;
    public GameObject Bomb;
    public GameObject SpeedBomb;
    public GameObject GameSeconds;
    public GameObject CountObjects;
    public GameObject ScaleInfoTime;
    public Sprite CapsuleGreen;
    public Sprite CapsuleRed;
    public int ObjeCount;
    List<GameObject> Objelerim;
    public int SpeedBombTime;
    List<string> Taglerim;
    List<float> DogumPozisyonlar;
    int randomTetromino;
    int randomDogum;
    int StarCounter;
    public int saniye;
    public int bombSaniye;
    public int BombsCount;
    public int Bombs;
    public int Level;
    public bool OyunDurdu;
    // Start is called before the first frame update
    void Start()
    {
        MasterSpeed = 1;
        GameObject.Find("TimeScaleInfo").GetComponent<MeshRenderer>().enabled = false;
        GameObject.Find("capsule").GetComponent<SpriteRenderer>().enabled = false;

        OyunDurdu = false;
        Level = PlayerPrefs.GetInt("SavedLevel");
     
        saniye = (int)Time.time;

        Objelerim = new List<GameObject>();
        Objelerim.Add(Cookie);
        Objelerim.Add(Egg);
        Objelerim.Add(Donut);
        Objelerim.Add(Melon);
        Objelerim.Add(Orange);
        Objelerim.Add(Star);

        DogumPozisyonlar = new List<float>();
        DogumPozisyonlar.Add(-2.13f);
        DogumPozisyonlar.Add(-1.07f);
        DogumPozisyonlar.Add(0);
        DogumPozisyonlar.Add(1.06f);
        DogumPozisyonlar.Add(2.11f);

        CreateBomb();



    }

    // Update is called once per frame
    string atilanTop = "";
    public bool oyunbaslasin = false;
    public bool MenuPausing;
    void Update()
    {



        if (!OyunDurdu && !MenuPausing)
        {
            if ((int)Time.time == saniye + 5)
            {
                oyunbaslasin = true;
            }
            if (oyunbaslasin)
            {
                if ((int)Time.time > saniye)
                {
                    CreateNewCube();

                    saniye = (int)Time.time;

                }
            }
        }


    }
    public float MasterSpeed;
    public void ChangeGameSpeed50()
    {
        if (MasterSpeed > 0 && MasterSpeed <= 3)
        {
            MasterSpeed = MasterSpeed * 1.2f;

        }
        else
        {
            if (MasterSpeed > 3)
            {
                MasterSpeed = 3;
            }
            else
            {
                MasterSpeed = 1;
            }

        }
        Time.timeScale = MasterSpeed;
        ScaleInfoTime.GetComponent<TextMeshPro>().text = "Time Scale: " + Decimal.Round((Decimal)Time.timeScale, 2).ToString() + "x";
        if (Time.timeScale >= 3)
        {
            GameObject.Find("TimeScaleInfo").GetComponent<MeshRenderer>().enabled = true;
            GameObject.Find("capsule").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.Find("capsule").GetComponent<SpriteRenderer>().sprite = CapsuleRed;
            if (!GameObject.Find("capsule").GetComponent<AudioSource>().isPlaying)
            {
                GameObject.Find("capsule").GetComponent<AudioSource>().Play();
            }
        }
        else if (Time.timeScale == 1)
        {
            GameObject.Find("TimeScaleInfo").GetComponent<MeshRenderer>().enabled = false;
            GameObject.Find("capsule").GetComponent<SpriteRenderer>().enabled = false;
            GameObject.Find("capsule").GetComponent<SpriteRenderer>().sprite = CapsuleGreen;

        }
        else
        {
            GameObject.Find("TimeScaleInfo").GetComponent<MeshRenderer>().enabled = true;
            GameObject.Find("capsule").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.Find("capsule").GetComponent<SpriteRenderer>().sprite = CapsuleGreen;
        }
    }
    void CreateNewCube()
    {
        SpeedBombTime++;
        StarCounter++;
        randomTetromino = new System.Random().Next(0, 5);
        ObjeCount++;


        if (atilanTop != Objelerim[randomTetromino].name)
        {

            randomDogum = new System.Random().Next(0, 5);

            Instantiate(Objelerim[randomTetromino], new Vector2(DogumPozisyonlar[randomDogum], 5.56f), Quaternion.identity);
            CreateSpeedBomb();
        }
        else
        {
            randomTetromino = new System.Random().Next(0, 5);
            randomDogum = new System.Random().Next(0, 5);
            Instantiate(Objelerim[randomTetromino], new Vector2(DogumPozisyonlar[randomDogum], 5.56f), Quaternion.identity);
            CreateSpeedBomb();
        }
        if (Level < 15 && StarCounter == 20)
        {
            
                randomDogum = new System.Random().Next(0, 5);
                Instantiate(Objelerim[5], new Vector3(DogumPozisyonlar[randomDogum], 5.56f, -1), Quaternion.identity);
                StarCounter = 0;

            
        }
        else if (Level>=15 && Level<30 && StarCounter==18)
        {
            randomDogum = new System.Random().Next(0, 5);
            Instantiate(Objelerim[5], new Vector3(DogumPozisyonlar[randomDogum], 5.56f, -1), Quaternion.identity);
            StarCounter = 0;
        }
        else if (Level >= 30 && Level < 50 && StarCounter == 15)
        {
            randomDogum = new System.Random().Next(0, 5);
            Instantiate(Objelerim[5], new Vector3(DogumPozisyonlar[randomDogum], 5.56f, -1), Quaternion.identity);
            StarCounter = 0;
        }
        else if (Level >= 50 && Level < 70 && StarCounter == 12)
        {
            randomDogum = new System.Random().Next(0, 5);
            Instantiate(Objelerim[5], new Vector3(DogumPozisyonlar[randomDogum], 5.56f, -1), Quaternion.identity);
            StarCounter = 0;
        }
        else if (Level >= 70  && StarCounter == 10)
        {
            randomDogum = new System.Random().Next(0, 5);
            Instantiate(Objelerim[5], new Vector3(DogumPozisyonlar[randomDogum], 5.56f, -1), Quaternion.identity);
            StarCounter = 0;
        }

    }

    IEnumerator CoroutineTest()
    {

        yield return new WaitForSeconds(1); // 1 saniye bekle
        CreateNewCube();


    }
    int randomdogumX;
    int randomdogumY;

    void CreateBomb()
    {

        if (Level < 10)
        {
            Instantiate(Bomb, new Vector2(new System.Random().Next(-2, 2), new System.Random().Next(-4, 2)), Quaternion.identity);
        }

        else if (Level >= 10 && Level < 20)//Speed bomb devreye girer
        {
            Instantiate(Bomb, new Vector2(new System.Random().Next(-2, 2), new System.Random().Next(-4, 2)), Quaternion.identity);
            Instantiate(Bomb, new Vector2(new System.Random().Next(-2, 2), new System.Random().Next(-4, 2)), Quaternion.identity);
        }
        else if (Level >= 20 && Level < 40)
        {
            Instantiate(Bomb, new Vector2(new System.Random().Next(-2, 2), new System.Random().Next(-4, 2)), Quaternion.identity);
            Instantiate(Bomb, new Vector2(new System.Random().Next(-2, 2), new System.Random().Next(-4, 2)), Quaternion.identity);
            Instantiate(Bomb, new Vector2(new System.Random().Next(-2, 2), new System.Random().Next(-4, 2)), Quaternion.identity);
        }
        else if (Level >= 40 && Level < 70)
        {
            Instantiate(Bomb, new Vector2(new System.Random().Next(-2, 2), new System.Random().Next(-4, 2)), Quaternion.identity);
            Instantiate(Bomb, new Vector2(new System.Random().Next(-2, 2), new System.Random().Next(-4, 2)), Quaternion.identity);
            Instantiate(Bomb, new Vector2(new System.Random().Next(-2, 2), new System.Random().Next(-4, 2)), Quaternion.identity);
            Instantiate(Bomb, new Vector2(new System.Random().Next(-2, 2), new System.Random().Next(-4, 2)), Quaternion.identity);
        }
        else if (Level >= 70)
        {
            Instantiate(Bomb, new Vector2(new System.Random().Next(-2, 2), new System.Random().Next(-4, 2)), Quaternion.identity);
            Instantiate(Bomb, new Vector2(new System.Random().Next(-2, 2), new System.Random().Next(-4, 2)), Quaternion.identity);
            Instantiate(Bomb, new Vector2(new System.Random().Next(-2, 2), new System.Random().Next(-4, 2)), Quaternion.identity);
            Instantiate(Bomb, new Vector2(new System.Random().Next(-2, 2), new System.Random().Next(-4, 2)), Quaternion.identity);
            Instantiate(Bomb, new Vector2(new System.Random().Next(-2, 2), new System.Random().Next(-4, 2)), Quaternion.identity);
        }
    }

    public bool Black_Cube_Bomb()
    {
        if (BombsCount > 0)
        {

            BombsCount--;
            GameObject.Find("Bombs_Count").GetComponent<TextMeshPro>().text = BombsCount.ToString();
            GameObject.Find("GameObject").GetComponent<LevelControl>().EliminateBomb = BombsCount;
            GameObject.Find("GameObject").GetComponent<LevelControl>().SavePrefabs();

            return true;
        }
        else
        {

            return false;
        }
    }

    public void CreateSpeedBomb()
    {

        if (SpeedBombTime == 120 && Level >= 15 && Level<30)
        {
            randomDogum = new System.Random().Next(0, 5);
            Instantiate(SpeedBomb, new Vector2(DogumPozisyonlar[randomDogum], 5.56f), Quaternion.identity);
            SpeedBombTime = 0;
        }
        else if (SpeedBombTime == 100 && Level >= 30 && Level < 50)
        {
            randomDogum = new System.Random().Next(0, 5);
            Instantiate(SpeedBomb, new Vector2(DogumPozisyonlar[randomDogum], 5.56f), Quaternion.identity);
            SpeedBombTime = 0;
        }
        else if (SpeedBombTime == 80 && Level >= 50 && Level < 70)
        {
            randomDogum = new System.Random().Next(0, 5);
            Instantiate(SpeedBomb, new Vector2(DogumPozisyonlar[randomDogum], 5.56f), Quaternion.identity);
            SpeedBombTime = 0;
        }
        else if (SpeedBombTime == 60 && Level >= 70)
        {
            randomDogum = new System.Random().Next(0, 5);
            Instantiate(SpeedBomb, new Vector2(DogumPozisyonlar[randomDogum], 5.56f), Quaternion.identity);
            SpeedBombTime = 0;
        }

    }

}
