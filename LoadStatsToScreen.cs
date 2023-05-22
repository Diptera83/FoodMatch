using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class LoadStatsToScreen : MonoBehaviour
{

    public GameObject claimTotalExpFoods20;
    public GameObject claimTotalExpDonuts5;
    public GameObject claimTotalExpEggs5;
    public GameObject claimTotalExpMelons5;
    public GameObject claimTotalExpCookies5;
    public GameObject claimTotalExpOranges5;
    public GameObject claimTotalExpBombs5;

    public GameObject claimTotalExpFoods30;
    public GameObject claimTotalExpDonuts10;
    public GameObject claimTotalExpEggs10;
    public GameObject claimTotalExpMelons10;
    public GameObject claimTotalExpCookies10;
    public GameObject claimTotalExpOranges10;
    public GameObject claimTotalExpBombs10;

    public GameObject claimTotalExpFoods50;
    public GameObject claimTotalExpDonuts20;
    public GameObject claimTotalExpEggs20;
    public GameObject claimTotalExpMelons20;
    public GameObject claimTotalExpCookies20;
    public GameObject claimTotalExpOranges20;
    public GameObject claimTotalExpBombs20;


    public int TotalStars { get; set; }
    public int GeneralExpFoods { get; set; }
    public int ExpCookie { get; set; }
    public int ExpDonut { get; set; }
    public int ExpEgg { get; set; }
    public int ExpOrange { get; set; }
    public int ExpMelon { get; set; }
    public int ExpBomb { get; set; }


    public int isGeneralExpFoods1000 { get; set; }
    public int isExpCookie200 { get; set; }
    public int isExpDonut500 { get; set; }
    public int isExpEgg400 { get; set; }
    public int isExpOrange100 { get; set; }
    public int isExpMelon300 { get; set; }
    public int isExpBomb50 { get; set; }

    public int isGeneralExpFoods5000 { get; set; }
    public int isExpCookie400 { get; set; }
    public int isExpDonut1000 { get; set; }
    public int isExpEgg800 { get; set; }
    public int isExpOrange200 { get; set; }
    public int isExpMelon600 { get; set; }
    public int isExpBomb200 { get; set; }

    public int isGeneralExpFoods10000 { get; set; }
    public int isExpCookie2000 { get; set; }
    public int isExpDonut5000 { get; set; }
    public int isExpEgg4000 { get; set; }
    public int isExpOrange1000 { get; set; }
    public int isExpMelon3000 { get; set; }
    public int isExpBomb1000 { get; set; }


    private void Start()
    {
        HepsiniKapat();
        TakeGeneralStats();
        //----------silinecek
        //PlayerPrefs.DeleteKey("isExpBomb50");
        //PlayerPrefs.DeleteKey("ExpBomb");
        //PlayerPrefs.SetInt("ExpBomb", 69);
        //PlayerPrefs.SetInt("isExpBomb50", 0);
        //PlayerPrefs.Save();

        //-------------------
    }
    public void HepsiniKapat()
    {
        claimTotalExpBombs5.SetActive(false);
        claimTotalExpCookies5.SetActive(false);
        claimTotalExpDonuts5.SetActive(false);
        claimTotalExpEggs5.SetActive(false);
        claimTotalExpMelons5.SetActive(false);
        claimTotalExpOranges5.SetActive(false);
        claimTotalExpFoods20.SetActive(false);
        claimTotalExpFoods20.SetActive(false) ;
        

    }

    public void TakeGeneralStats()
    {
        TotalStars = PlayerPrefs.GetInt("SavedStars");
        GeneralExpFoods = PlayerPrefs.GetInt("GeneralExpFoods");
        ExpCookie = PlayerPrefs.GetInt("ExpCookie");
        ExpDonut = PlayerPrefs.GetInt("ExpDonut");
        ExpEgg = PlayerPrefs.GetInt("ExpEgg");
        ExpOrange = PlayerPrefs.GetInt("ExpOrange");
        ExpMelon = PlayerPrefs.GetInt("ExpMelon");
        ExpBomb = PlayerPrefs.GetInt("ExpBomb");


        //--------------------------
        if (PlayerPrefs.HasKey("isGeneralExpFoods1000")) { isGeneralExpFoods1000 = PlayerPrefs.GetInt("isGeneralExpFoods1000"); }
        else { PlayerPrefs.SetInt("isGeneralExpFoods1000", 0); }

        if (PlayerPrefs.HasKey("isExpCookie200")) { isExpCookie200 = PlayerPrefs.GetInt("isExpCookie200"); }
        else { PlayerPrefs.SetInt("isExpCookie200", 0); }

        if (PlayerPrefs.HasKey("isExpDonut500")) { isExpDonut500 = PlayerPrefs.GetInt("isExpDonut500"); }
        else { PlayerPrefs.SetInt("isExpDonut500", 0); }

        if (PlayerPrefs.HasKey("isExpEgg400")) { isExpEgg400 = PlayerPrefs.GetInt("isExpEgg400"); }
        else { PlayerPrefs.SetInt("isExpEgg400", 0); }

        if (PlayerPrefs.HasKey("isExpOrange100")) { isExpOrange100 = PlayerPrefs.GetInt("isExpOrange100"); }
        else { PlayerPrefs.SetInt("isExpOrange100", 0); }

        if (PlayerPrefs.HasKey("isExpMelon300")) { isExpMelon300 = PlayerPrefs.GetInt("isExpMelon300"); }
        else { PlayerPrefs.SetInt("isExpMelon300", 0); }

        if (PlayerPrefs.HasKey("isExpBomb50")) { isExpBomb50 = PlayerPrefs.GetInt("isExpBomb50"); }
        else { PlayerPrefs.SetInt("isExpBomb50", 0); }

        PlayerPrefs.Save();
        //--------------------------
        if (PlayerPrefs.HasKey("isGeneralExpFoods5000")) { isGeneralExpFoods5000 = PlayerPrefs.GetInt("isGeneralExpFoods5000"); }
        else { PlayerPrefs.SetInt("isGeneralExpFoods5000", 0); }

        if (PlayerPrefs.HasKey("isExpCookie400")) { isExpCookie400 = PlayerPrefs.GetInt("isExpCookie400"); }
        else { PlayerPrefs.SetInt("isExpCookie400", 0); }

        if (PlayerPrefs.HasKey("isExpDonut1000")) { isExpDonut1000 = PlayerPrefs.GetInt("isExpDonut1000"); }
        else { PlayerPrefs.SetInt("isExpDonut1000", 0); }

        if (PlayerPrefs.HasKey("isExpEgg800")) { isExpEgg800 = PlayerPrefs.GetInt("isExpEgg800"); }
        else { PlayerPrefs.SetInt("isExpEgg800", 0); }

        if (PlayerPrefs.HasKey("isExpOrange200")) { isExpOrange200 = PlayerPrefs.GetInt("isExpOrange200"); }
        else { PlayerPrefs.SetInt("isExpOrange200", 0); }

        if (PlayerPrefs.HasKey("isExpMelon600")) { isExpMelon600 = PlayerPrefs.GetInt("isExpMelon600"); }
        else { PlayerPrefs.SetInt("isExpMelon600", 0); }

        if (PlayerPrefs.HasKey("isExpBomb200")) { isExpBomb200 = PlayerPrefs.GetInt("isExpBomb200"); }
        else { PlayerPrefs.SetInt("isExpBomb200", 0); }

        PlayerPrefs.Save();
        //--------------------------
        if (PlayerPrefs.HasKey("isGeneralExpFoods10000")) { isGeneralExpFoods10000 = PlayerPrefs.GetInt("isGeneralExpFoods10000"); }
        else { PlayerPrefs.SetInt("isGeneralExpFoods10000", 0); }

        if (PlayerPrefs.HasKey("isExpCookie2000")) { isExpCookie2000 = PlayerPrefs.GetInt("isExpCookie2000"); }
        else { PlayerPrefs.SetInt("isExpCookie2000", 0); }

        if (PlayerPrefs.HasKey("isExpDonut5000")) { isExpDonut5000 = PlayerPrefs.GetInt("isExpDonut5000"); }
        else { PlayerPrefs.SetInt("isExpDonut5000", 0); }

        if (PlayerPrefs.HasKey("isExpEgg4000")) { isExpEgg4000 = PlayerPrefs.GetInt("isExpEgg4000"); }
        else { PlayerPrefs.SetInt("isExpEgg4000", 0); }

        if (PlayerPrefs.HasKey("isExpOrange1000")) { isExpOrange1000 = PlayerPrefs.GetInt("isExpOrange1000"); }
        else { PlayerPrefs.SetInt("isExpOrange1000", 0); }

        if (PlayerPrefs.HasKey("isExpMelon3000")) { isExpMelon3000 = PlayerPrefs.GetInt("isExpMelon3000"); }
        else { PlayerPrefs.SetInt("isExpMelon3000", 0); }

        if (PlayerPrefs.HasKey("isExpBomb1000")) { isExpBomb1000 = PlayerPrefs.GetInt("isExpBomb1000"); }
        else { PlayerPrefs.SetInt("isExpBomb1000", 0); }

        PlayerPrefs.Save();
        //--------------------------

        //------------------------------------------------

        GameObject.Find("TotalExpFoods").GetComponent<TextMeshPro>().text = GeneralExpFoods.ToString();
        GameObject.Find("TotalExpDonuts").GetComponent<TextMeshPro>().text = ExpDonut.ToString();
        GameObject.Find("TotalExpEggs").GetComponent<TextMeshPro>().text = ExpEgg.ToString();
        GameObject.Find("TotalExpMelons").GetComponent<TextMeshPro>().text = ExpMelon.ToString();
        GameObject.Find("TotalExpCookies").GetComponent<TextMeshPro>().text = ExpCookie.ToString();
        GameObject.Find("TotalExpOranges").GetComponent<TextMeshPro>().text = ExpOrange.ToString();
        GameObject.Find("TotalExpBombs").GetComponent<TextMeshPro>().text = ExpBomb.ToString();
        GameObject.Find("TotalStarsCount").GetComponent<TextMeshPro>().text = TotalStars.ToString();
        //---------------------------
        if (isGeneralExpFoods1000 == 0 && GeneralExpFoods >= 1000 && GeneralExpFoods < 5000)
        {
            claimTotalExpFoods20.SetActive(true);
            claimTotalExpFoods20.GetComponent<claimTotalExpFoodsclick>().GiftStarsCount = 20;


        }
        if (isGeneralExpFoods5000 == 0 && GeneralExpFoods >= 5000 && GeneralExpFoods < 10000)
        {
            claimTotalExpFoods20.SetActive(true);
            claimTotalExpFoods20.GetComponent<claimTotalExpFoodsclick>().GiftStarsCount = 30;


        }
        if (isGeneralExpFoods10000 == 0 && GeneralExpFoods >= 10000)
        {
            claimTotalExpFoods20.SetActive(true);
            claimTotalExpFoods20.GetComponent<claimTotalExpFoodsclick>().GiftStarsCount = 50;


        }




        //-------------------------
        if (isExpDonut500 == 0 && ExpDonut >= 500 && ExpDonut < 1000)
        {
            claimTotalExpDonuts5.SetActive(true);
            claimTotalExpDonuts5.GetComponent<claimTotalExpDonuts5>().GiftStarsCount = 5;


        }
        if (isExpDonut500 == 0 && ExpDonut >= 1000 && ExpDonut < 5000)
        {
            claimTotalExpDonuts5.SetActive(true);
            claimTotalExpDonuts5.GetComponent<claimTotalExpDonuts5>().GiftStarsCount = 10;


        }
        if (isExpDonut1000 == 0 && ExpDonut >= 5000)
        {
            claimTotalExpDonuts5.SetActive(true);
            claimTotalExpDonuts5.GetComponent<claimTotalExpDonuts5>().GiftStarsCount = 20;


        }
        //--------------------------
        if (isExpEgg400 == 0 && ExpEgg >= 400 && ExpEgg < 800)
        {
            claimTotalExpEggs5.SetActive(true);
            claimTotalExpEggs5.GetComponent<claimTotalExpEggs5>().GiftStarsCount = 5;


        }
        if (isExpEgg800 == 0 && ExpEgg >= 800 && ExpEgg < 4000)
        {
            claimTotalExpEggs5.SetActive(true);
            claimTotalExpEggs5.GetComponent<claimTotalExpEggs5>().GiftStarsCount = 10;


        }
        if (isExpEgg4000 == 0 && ExpEgg >= 4000)
        {
            claimTotalExpEggs5.SetActive(true);
            claimTotalExpEggs5.GetComponent<claimTotalExpEggs5>().GiftStarsCount = 20;


        }

        if (isExpMelon300 == 0 && ExpMelon >= 300 && ExpMelon < 600)
        {
            claimTotalExpMelons5.SetActive(true);
            claimTotalExpMelons5.GetComponent<claimTotalExpMelons5>().GiftStarsCount = 5;


        }
        if (isExpMelon600 == 0 && ExpMelon >= 600 && ExpMelon < 3000)
        {
            claimTotalExpMelons5.SetActive(true);
            claimTotalExpMelons5.GetComponent<claimTotalExpMelons5>().GiftStarsCount = 10;


        }
        if (isExpMelon3000 == 0 && ExpMelon >= 3000)
        {
            claimTotalExpMelons5.SetActive(true);
            claimTotalExpMelons5.GetComponent<claimTotalExpMelons5>().GiftStarsCount = 20;


        }
        //---------------------------------
        if (isExpCookie200 == 0 && ExpCookie >= 200 && ExpCookie < 400)
        {
            claimTotalExpCookies5.SetActive(true);
            claimTotalExpCookies5.GetComponent<claimTotalExpCookies5>().GiftStarsCount = 5;


        }
        if (isExpCookie400 == 0 && ExpCookie >= 400 && ExpCookie < 2000)
        {
            claimTotalExpCookies5.SetActive(true);
            claimTotalExpCookies5.GetComponent<claimTotalExpCookies5>().GiftStarsCount = 10;


        }
        if (isExpCookie2000 == 0 && ExpCookie >= 2000)
        {
            claimTotalExpCookies5.SetActive(true);
            claimTotalExpCookies5.GetComponent<claimTotalExpCookies5>().GiftStarsCount = 20;


        }
        //----------------------------------------------
        if (isExpOrange100 == 0 && ExpOrange >= 100 && ExpOrange < 200)
        {
            claimTotalExpOranges5.SetActive(true);
            claimTotalExpOranges5.GetComponent<claimTotalExpOranges5>().GiftStarsCount = 5;


        }
        if (isExpOrange200 == 0 && ExpOrange >= 200 && ExpOrange < 1000)
        {
            claimTotalExpOranges5.SetActive(true);
            claimTotalExpOranges5.GetComponent<claimTotalExpOranges5>().GiftStarsCount = 10;


        }
        if (isExpOrange1000 == 0 && ExpOrange >= 1000)
        {
            claimTotalExpOranges5.SetActive(true);
            claimTotalExpOranges5.GetComponent<claimTotalExpOranges5>().GiftStarsCount = 20;


        }
        //-----------------------------------
        if (isExpBomb50 == 0 && ExpBomb >= 50 && ExpBomb < 200)
        {
            claimTotalExpBombs5.SetActive(true);
            claimTotalExpBombs5.GetComponent<claimTotalExpBombs5>().GiftStarsCount = 5;


        }
        if (isExpBomb200 == 0 && ExpBomb >= 200 && ExpBomb < 1000)
        {
            claimTotalExpBombs5.SetActive(true);
            claimTotalExpBombs5.GetComponent<claimTotalExpBombs5>().GiftStarsCount = 10;


        }
        if (isExpBomb1000 == 0 && ExpBomb >= 1000)
        {
            claimTotalExpBombs5.SetActive(true);
            claimTotalExpBombs5.GetComponent<claimTotalExpBombs5>().GiftStarsCount = 20;


        }
    }




}
