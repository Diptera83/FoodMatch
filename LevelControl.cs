using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class LevelControl : MonoBehaviour
{
    public Sprite FinishAllGameEn;
    public Sprite FinishAllGameTur;

    public AudioClip touch1;
    public AudioClip touch2;
    public AudioClip touch3;
    public AudioClip touch4;

    private Animator mAnimator;
    public int PlayerLevel;


    public int Level;
    public int Done;

    public bool SkorDegistimi = false;
    public int ToplamPuan;
    public int ToplamYildiz;
    public int DragBomb;
    public int TimeBomb;
    public int TurnBomb;
    public int EliminateBomb;
    public List<GameObject> TargetObjects;
    public List<GameObject> MyObjects;
    public List<int> missions;
    public List<int> MissionsFinished;
    public GameObject Cookie;
    public GameObject Egg;
    public GameObject Donut;
    public GameObject Orange;
    public GameObject Melon;

    public int Goal1;
    public int Goal2;
    public int Goal3;
    public int Goal4;
    public int Goal5;

    public int ExplodeCounter1;
    public int ExplodeCounter2;
    public int ExplodeCounter3;
    public int ExplodeCounter4;
    public int ExplodeCounter5;
    public int ExplodeMainCounter;

    public bool finished1;
    public bool finished2;
    public bool finished3;
    public bool finished4;
    public bool finished5;
    public int[] ReklamLevel;
    public bool levelgecildimi;
    public bool levelkaybedildi;
    
    void Start()
    {
      

        levelgecildimi = false;
        levelkaybedildi = false;
        GetPrefabs();
        if (Level==1)
        {
            GameObject.Find("DragObjectsTanitim").GetComponent<dragbombsinfo>().showinfo();
        }
        else if (Level==3) 
        {
            GameObject.Find("SUPERPOWERTanitim").GetComponent<superpoertanitim>().showinfo();
        }
        else if (Level == 10)
        {
            GameObject.Find("BombTeleportTanitim").GetComponent<bombscanteleportinfo>().showinfo();
        }
        else if (Level == 15)
        {
            GameObject.Find("SpeedBombTanitim").GetComponent<speedbombinfo>().showinfo();
        }

        levelgecildimi = false;
        //PlayerPrefs.DeleteKey("SavedLevel");
        //////////PlayerPrefs.DeleteKey("SavedScore");
        //////////PlayerPrefs.DeleteKey("SavedStars");
        //////////PlayerPrefs.DeleteKey("DragBomb");
        //////////PlayerPrefs.DeleteKey("TimeBomb");
        //////////PlayerPrefs.DeleteKey("TurnBomb");
        //PlayerPrefs.SetInt("SavedLevel", 15);
        //////////PlayerPrefs.SetInt("SavedScore", 0);
        //////////PlayerPrefs.SetInt("SavedStars", 100);
        //PlayerPrefs.Save();

        ReklamLevel = new int[] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35, 37, 39, 41, 43, 45, 47, 49, 51, 53, 55, 57, 59, 61, 63, 65, 67, 69, 71, 73, 75, 77, 79, 81, 83, 85, 87, 89, 91, 93, 95, 97, 99 };

        Resolution[] resolutions = Screen.resolutions;
        int xr;
        int yr;

        // Print the resolutions
        foreach (var res in resolutions)
        {
            xr = (int)res.width;

            yr = (int)res.height;
        }



        Level = GetPlayerLevel();

        if (ReklamLevel.Contains(Level))
        {
            //GameObject.Find("GameObject").GetComponent<GecisReklami>().GameOverVideo();
        }
        TargetObjects = new List<GameObject>();
        MyObjects = new List<GameObject>();
        missions = new List<int>();
        MissionsFinished = new List<int>();
        MyObjects.Add(Cookie);
        MyObjects.Add(Egg);
        MyObjects.Add(Donut);
        MyObjects.Add(Orange);
        MyObjects.Add(Melon);

        int sayac = 1;
        TargetObjects.Clear();

        while (sayac <= 5)
        {
            int randomTargetNumber = new System.Random().Next(0, 5);

            if (!TargetObjects.Contains(MyObjects[randomTargetNumber]))
            {
                TargetObjects.Add(MyObjects[randomTargetNumber]);

                sayac++;
            }
        }

        for (int i = 0; i < 5; i++)
        {
            if (Level <= 2)
            {
                int randomTargetNumber = 1;
                missions.Add(randomTargetNumber);
            }
            else if (Level > 2 && Level < 10)
            {
                int randomTargetNumber = new System.Random().Next(1, 2);
                missions.Add(randomTargetNumber);
            }

            else if (Level >= 10 && Level < 20)
            {
                int randomTargetNumber = new System.Random().Next(1, 3);
                missions.Add(randomTargetNumber);
            }
            else if (Level >= 20 && Level < 30)
            {
                int randomTargetNumber = new System.Random().Next(2, 5);
                missions.Add(randomTargetNumber);
            }
            else if (Level >= 30)
            {
                int randomTargetNumber = new System.Random().Next(3, 5);
                missions.Add(randomTargetNumber);
            }

        }
        GameObject.Find("LevelText").GetComponent<TextMeshPro>().text = Level.ToString();

        GameObject.Find("ScoreText1").GetComponent<TextMeshPro>().text = "0/" + missions[0];
        GameObject.Find("ScoreText2").GetComponent<TextMeshPro>().text = "0/" + missions[1];
        GameObject.Find("ScoreText3").GetComponent<TextMeshPro>().text = "0/" + missions[2];
        GameObject.Find("ScoreText4").GetComponent<TextMeshPro>().text = "0/" + missions[3];
        GameObject.Find("ScoreText5").GetComponent<TextMeshPro>().text = "0/" + missions[4];

        GameObject.Find("zemin3").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.Find("zemin4").GetComponent<SpriteRenderer>().enabled = false;

        Instantiate(TargetObjects[0], new Vector3(-2.33f, 4.33f, -0.066f), Quaternion.identity);
        Instantiate(TargetObjects[1], new Vector3(-1.39f, 4.33f, -0.066f), Quaternion.identity);
        Instantiate(TargetObjects[2], new Vector3(-0.46f, 4.33f, -0.066f), Quaternion.identity);
        GameObject.Find("ScoreText4").GetComponent<TextMeshPro>().enabled = false;
        GameObject.Find("ScoreText5").GetComponent<TextMeshPro>().enabled = false;
        ExplodeMainCounter = 10;
        if (Level >= 10 && Level < 30)
        {
            Instantiate(TargetObjects[3], new Vector3(0.43f, 4.33f, -0.066f), Quaternion.identity);


            GameObject.Find("zemin3").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.Find("zemin4").GetComponent<SpriteRenderer>().enabled = false;
            GameObject.Find("ScoreText4").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("ScoreText5").GetComponent<TextMeshPro>().enabled = false;

        }
        else if (Level >= 30)
        {
            Instantiate(TargetObjects[3], new Vector3(0.43f, 4.33f, -0.066f), Quaternion.identity);
            Instantiate(TargetObjects[4], new Vector3(1.35f, 4.33f, -0.066f), Quaternion.identity);


            GameObject.Find("zemin3").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.Find("zemin4").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.Find("ScoreText4").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("ScoreText5").GetComponent<TextMeshPro>().enabled = true;
        }
        ToplamPuan = PlayerPrefs.GetInt("SavedScore");
        ToplamYildiz = PlayerPrefs.GetInt("SavedStars");
        GameObject.Find("TotalStars").GetComponent<TextMeshPro>().text = ToplamYildiz.ToString();

    }

    // Update is called once per frame
    void Update()
    {

        SkorGuncelle();
        ShowSuperpowerhint();


    }

    public void SkorTakipcisi(GameObject Skor, bool ExplodeCount)
    {
        if (TargetObjects.Contains(Skor))
        {
            switch (TargetObjects.IndexOf(Skor))
            {
                case 0:
                    if (!finished1)
                    {
                        if (ExplodeCount)
                        {
                            Goal1++; SkorDegistimi = true;


                        }
                        if (Goal1 >= missions[0])
                        {
                            GameObject.Find("zemin0").GetComponent<SpriteRenderer>().color = new Color(0, 1, 0, 1);

                            Done++;
                            finished1 = true;
                        }
                    }


                    break;

                case 1:
                    if (!finished2)
                    {
                        if (ExplodeCount)
                        {
                            Goal2++; SkorDegistimi = true;


                        }
                        if (Goal2 >= missions[1])
                        {
                            GameObject.Find("zemin1").GetComponent<SpriteRenderer>().color = new Color(0, 1, 0, 1);
                            Done++;
                            finished2 = true;
                        }
                    }

                    break;

                case 2:
                    if (!finished3)
                    {
                        if (ExplodeCount)
                        {
                            Goal3++; SkorDegistimi = true;


                        }
                        if (Goal3 >= missions[2])
                        {
                            GameObject.Find("zemin2").GetComponent<SpriteRenderer>().color = new Color(0, 1, 0, 1);
                            Done++;
                            finished3 = true;
                        }
                    }

                    break;

                case 3:
                    if (Level >= 10)
                    {

                        if (!finished4)
                        {
                            if (ExplodeCount)
                            {
                                Goal4++; SkorDegistimi = true;


                            }
                            if (Goal4 >= missions[3])
                            {
                                GameObject.Find("zemin3").GetComponent<SpriteRenderer>().color = new Color(0, 1, 0, 1);
                                Done++;
                                finished4 = true;
                            }
                        }

                    }

                    break;
                case 4:
                    if (Level >= 20)
                    {
                        if (!finished5)
                        {
                            if (ExplodeCount)
                            {
                                Goal5++; SkorDegistimi = true;


                            }
                            if (Goal5 >= missions[4])
                            {
                                GameObject.Find("zemin4").GetComponent<SpriteRenderer>().color = new Color(0, 1, 0, 1);
                                Done++;
                                finished5 = true;
                            }
                        }

                    }

                    break;
                default:
                    break;
            }

        }


    }
    void SkorGuncelle()
    {
        if (SkorDegistimi)
        {
            GameObject.Find("ScoreText1").GetComponent<TextMeshPro>().text = Goal1 + "/" + missions[0].ToString();
            GameObject.Find("ScoreText2").GetComponent<TextMeshPro>().text = Goal2 + "/" + missions[1].ToString();
            GameObject.Find("ScoreText3").GetComponent<TextMeshPro>().text = Goal3 + "/" + missions[2].ToString();
            GameObject.Find("ScoreText4").GetComponent<TextMeshPro>().text = Goal4 + "/" + missions[3].ToString();
            GameObject.Find("ScoreText5").GetComponent<TextMeshPro>().text = Goal5 + "/" + missions[4].ToString();


            LevelUp();
            SkorDegistimi = false;


        }
    }
    public void PuanTopla(int puan)
    {
        ToplamPuan = ToplamPuan + puan;


        SkorDegistimi = true;
    }

    public void LevelUp()
    {

        if (Level < 10 && Done == 3 && !levelgecildimi)
        {

            Level++;
            SetPlayerInfo(Level, ToplamPuan);

            GameObject.Find("LevelText").GetComponent<TextMeshPro>().text = Level.ToString();
            levelgecildimi = true;
        }
        else if (Level >= 10 && Level < 20 && Done == 4 && !levelgecildimi)
        {
            Level++;
            SetPlayerInfo(Level, ToplamPuan);

            GameObject.Find("LevelText").GetComponent<TextMeshPro>().text = Level.ToString();
            levelgecildimi = true;
        }
        else if (Level >= 20 && Done >= 5 && !levelgecildimi)
        {
            Level++;
            SetPlayerInfo(Level, ToplamPuan);

            GameObject.Find("LevelText").GetComponent<TextMeshPro>().text = Level.ToString();
            levelgecildimi = true;
        }



    }

    public int GetPlayerLevel()
    {

        PlayerLevel = PlayerPrefs.GetInt("SavedLevel");

        return PlayerLevel;

    }
    public int GetPlayerScore()
    {

        ToplamPuan = PlayerPrefs.GetInt("SavedScore");
        return ToplamPuan;

    }
    int RealLevel;
    public void SetPlayerInfo(int level, int score)
    {

        if (Level == 100) //OYUN BÝTTÝ!
        {
            if (PlayerPrefs.GetString("Lan") == "Tur")
            {
                GameObject.Find("FinishAllGame").GetComponent<SpriteRenderer>().sprite = FinishAllGameTur;
            }
            else
            {
                GameObject.Find("FinishAllGame").GetComponent<SpriteRenderer>().sprite = FinishAllGameEn;
            }

            GameObject.Find("FinishAllGame").transform.position = new Vector3(-0.04f, 0.2f, 0);
        }
        else
        {
            GameObject.Find("LevelGectin").transform.position = new Vector3(0, 0, 0);
           
            GameObject.Find("Burger_Menu").GetComponent<BoxCollider2D>().enabled = false;
            GameObject.Find("Burger_Menu").GetComponent<SpriteRenderer>().enabled = false;
            GameObject.Find("Burger_Menu").transform.position = new Vector3(10.55f, 4.57f, 0);
        }

        GameObject.Find("GameObject").GetComponent<oyun>().MenuPausing = true;
        SavePrefabs();


        switch (new System.Random().Next(1, 5))
        {
            case 1: transform.GetComponent<AudioSource>().clip = touch1; break;
            case 2: transform.GetComponent<AudioSource>().clip = touch2; break;
            case 3: transform.GetComponent<AudioSource>().clip = touch3; break;
            case 4: transform.GetComponent<AudioSource>().clip = touch4; break;


            default:
                break;
        }
        transform.GetComponent<AudioSource>().Play();
        Time.timeScale = 1;



    }

    public void SavePrefabs()
    {

        PlayerPrefs.DeleteKey("SavedLevel");
        PlayerPrefs.DeleteKey("SavedLevel_Real");
        PlayerPrefs.DeleteKey("SavedScore");
        PlayerPrefs.DeleteKey("SavedStars");
        PlayerPrefs.DeleteKey("DragBomb");
        PlayerPrefs.DeleteKey("TimeBomb");
        PlayerPrefs.DeleteKey("TurnBomb");
        PlayerPrefs.DeleteKey("EliminateBomb");
        PlayerPrefs.SetInt("SavedLevel", Level);
        if (PlayerPrefs.GetInt("SavedLevel_Real")<Level)
        {
            PlayerPrefs.SetInt("SavedLevel_Real", Level);
        }
     
        PlayerPrefs.SetInt("SavedScore", ToplamPuan);
        PlayerPrefs.SetInt("SavedStars", ToplamYildiz);
        PlayerPrefs.SetInt("DragBomb", DragBomb);
        PlayerPrefs.SetInt("TimeBomb", TimeBomb);
        PlayerPrefs.SetInt("TurnBomb", TurnBomb);
        PlayerPrefs.SetInt("EliminateBomb", EliminateBomb);
        PlayerPrefs.Save();
    }

    public void GetPrefabs()
    {

        Level = PlayerPrefs.GetInt("SavedLevel");
        ToplamYildiz = PlayerPrefs.GetInt("SavedStars");
        DragBomb = PlayerPrefs.GetInt("DragBomb");
        TimeBomb = PlayerPrefs.GetInt("TimeBomb");
        TurnBomb = PlayerPrefs.GetInt("TurnBomb");
        EliminateBomb = PlayerPrefs.GetInt("EliminateBomb");

        GameObject.Find("Calendar").transform.Find("LevelText").GetComponent<TextMeshPro>().text = Level.ToString();
        GameObject.Find("TotalStars").GetComponent<TextMeshPro>().text = ToplamYildiz.ToString();
        GameObject.Find("SW_Drag").GetComponent<TextMeshPro>().text = DragBomb.ToString();
        GameObject.Find("SW_Turn").GetComponent<TextMeshPro>().text = TurnBomb.ToString();
        GameObject.Find("SW_Time").GetComponent<TextMeshPro>().text = TimeBomb.ToString();
        GameObject.Find("Bombs_Count").GetComponent<TextMeshPro>().text = EliminateBomb.ToString();
        GameObject.Find("GameObject").GetComponent<oyun>().BombsCount = EliminateBomb;

        GameObject.Find("SP_Menu").transform.Find("Drag_Bombs_Count").GetComponent<TextMeshPro>().text = DragBomb.ToString();
        GameObject.Find("SP_Menu").transform.Find("Time_Bombs_Count").GetComponent<TextMeshPro>().text = TimeBomb.ToString();
        GameObject.Find("SP_Menu").transform.Find("Transformer_Bombs_Count").GetComponent<TextMeshPro>().text = TurnBomb.ToString();
        GameObject.Find("SP_Menu").transform.Find("Bombs_Count_balon").GetComponent<TextMeshPro>().text = EliminateBomb.ToString();
    }

    public void ShowSuperpowerhint()
    {
        if (Level<10 && DragBomb==0 && TimeBomb==0 && TurnBomb==0 && EliminateBomb==0)
        {
            GameObject.Find("SuperPowerHint").transform.position = new Vector3(1.50f, 4.57f, 0);
        }
        else
        {
            GameObject.Find("SuperPowerHint").transform.position = new Vector3(12.44f, 4.57f, 0);
        }
    }
}

