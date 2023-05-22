using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Language : MonoBehaviour
{
    public Sprite ResumeTurpressed;
    public Sprite GameTutorialTur;
    public Sprite GameTutorialEn;
    public Sprite GameinfoTur;
    public Sprite GameinfoEn;
    public Sprite QuitButtonEn;
    public Sprite QuitButtonTur;
    public Sprite NewGameButtonEn;
    public Sprite NewGameButtonTur;
    public Sprite NewGameButtonTurPressed;
    public Sprite NewGameButtonEnPressed;
    public Sprite ResumeButtonEn;
    public Sprite ResumeButtonTur;
    public Sprite TakeSuperPowersEn;
    public Sprite TakeSuperPowersTur;
    public Sprite MainMapEn;
    public Sprite MainMapTur;
    public string AppLan;
    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.DeleteKey("SavedLevel");
        //////PlayerPrefs.DeleteKey("SavedScore");
        //////PlayerPrefs.DeleteKey("SavedStars");
        //////PlayerPrefs.DeleteKey("DragBomb");
        //////PlayerPrefs.DeleteKey("TimeBomb");
        //////PlayerPrefs.DeleteKey("TurnBomb");
        //PlayerPrefs.SetInt("SavedLevel", 45);
        //////PlayerPrefs.SetInt("SavedScore", 0);
        //////PlayerPrefs.SetInt("SavedStars", 100);
        //PlayerPrefs.Save();

        if (PlayerPrefs.HasKey("Lan"))
        {
            AppLan = PlayerPrefs.GetString("Lan");

            if (AppLan == "En")
            {
                eNMenu();
                GameObject.Find("tur").GetComponent<SpriteRenderer>().sprite = GameObject.Find("tur").GetComponent<TurButton>().ingilizbayrak;
                GameObject.Find("en").GetComponent<SpriteRenderer>().sprite = GameObject.Find("tur").GetComponent<TurButton>().TurkBayrak;
            }
            else
            {
                TurMenu();
                GameObject.Find("tur").GetComponent<SpriteRenderer>().sprite = GameObject.Find("tur").GetComponent<TurButton>().TurkBayrak;
                GameObject.Find("en").GetComponent<SpriteRenderer>().sprite = GameObject.Find("tur").GetComponent<TurButton>().ingilizbayrak;

            }
        }
        else
        {
         
            eNMenu();
            PlayerPrefs.SetString("Lan", "En");
            PlayerPrefs.Save();
            AppLan = "En";
            GameObject.Find("tur").GetComponent<SpriteRenderer>().sprite = GameObject.Find("tur").GetComponent<TurButton>().ingilizbayrak;
            GameObject.Find("en").GetComponent<SpriteRenderer>().sprite = GameObject.Find("tur").GetComponent<TurButton>().TurkBayrak;
        }

    }

    public void TurMenu()
    {
    
        GameObject.Find("MAPTEXT").GetComponent<TextMeshPro>().text = "HARITA";
        GameObject.Find("MAPTEXT (1)").GetComponent<TextMeshPro>().text = "ISTATISTIK";
        GameObject.Find("colleted").GetComponent<TextMeshPro>().text = "TOPLAM YILDIZ";
        GameObject.Find("sp1").GetComponent<TextMeshPro>().text = "SURUKLEME BOMBASI";
        GameObject.Find("DB_info (1)").GetComponent<TextMeshPro>().text = "3 ADET LAZIM";
        GameObject.Find("TIme Bomb").GetComponent<TextMeshPro>().text = "ZAMAN BOMBASI";
        GameObject.Find("DB_info").GetComponent<TextMeshPro>().text = "4 ADET LAZIM";
        GameObject.Find("TIme Bomb (1)").GetComponent<TextMeshPro>().text = "DONUÞTURUCU BOMBA";
        GameObject.Find("DB_info (2)").GetComponent<TextMeshPro>().text = "10 ADET LAZIM";
        GameObject.Find("BackButton").GetComponent<TextMeshPro>().text = "GERI";
        //GameObject.Find("donut_ps2").transform.Find("backButton").GetComponent<TextMeshPro>().text = "GERI";
        GameObject.Find("sure").GetComponent<TextMeshPro>().text = "EN BASTAN BASLAMAYI ONAYLIYOR MUSUNUZ?";
        GameObject.Find("YES").GetComponent<TextMeshPro>().text = "EVET";
        GameObject.Find("NO").GetComponent<TextMeshPro>().text = "HAYIR";
        GameObject.Find("TotalStars").GetComponent<TextMeshPro>().text = "TOPLAM YILDIZ:";
        GameObject.Find("totalExpFoodsText").GetComponent<TextMeshPro>().text = "TOP.PAT.YEMEKLER:";
        GameObject.Find("totalExpDONUTSText").GetComponent<TextMeshPro>().text = "TOP.PAT.DONUTLAR:";
        GameObject.Find("totalExpEGGSText").GetComponent<TextMeshPro>().text = "TOP.PAT.YUMURTALAR:";
        GameObject.Find("totalExpMELONSText").GetComponent<TextMeshPro>().text = "TOP.PAT.KARPUZLAR:";
        GameObject.Find("totalExpCOOKIESText").GetComponent<TextMeshPro>().text = "TOP.PAT.KURABÝYELER:";
        GameObject.Find("totalExpORANGESText").GetComponent<TextMeshPro>().text = "TOP.PAT.PORTAKALLAR:";
        GameObject.Find("totalExpBOMBSText").GetComponent<TextMeshPro>().text = "TOP.PAT. BOMBALAR:";
        GameObject.Find("Eliminate").GetComponent<TextMeshPro>().text = "Etkisizlestirme Bombasi";
        GameObject.Find("DB_info (3)").GetComponent<TextMeshPro>().text = "5 ADET LAZIM";

        GameObject.Find("Quit_Normal 1").GetComponent<SpriteRenderer>().sprite = GameObject.Find("arkaduvar (1)").GetComponent<Language>().QuitButtonTur;
        GameObject.Find("take_Superpowers").GetComponent<SpriteRenderer>().sprite = GameObject.Find("arkaduvar (1)").GetComponent<Language>().TakeSuperPowersTur;
        GameObject.Find("NG_Normal 1").GetComponent<SpriteRenderer>().sprite = GameObject.Find("arkaduvar (1)").GetComponent<Language>().NewGameButtonTur;
        GameObject.Find("NG_Normal 1").GetComponent<New_Game_Button>().NewSprite = GameObject.Find("arkaduvar (1)").GetComponent<Language>().NewGameButtonTurPressed;
        GameObject.Find("RG_Normal").GetComponent<SpriteRenderer>().sprite = GameObject.Find("arkaduvar (1)").GetComponent<Language>().ResumeButtonTur;
        GameObject.Find("RG_Normal").GetComponent<rESUME_gAME_bUTTON>().NewSprite = ResumeTurpressed;
        GameObject.Find("MAP").GetComponent<SpriteRenderer>().sprite = GameObject.Find("arkaduvar (1)").GetComponent<Language>().MainMapTur;
        GameObject.Find("gameinfo").GetComponent<SpriteRenderer>().sprite = GameinfoTur;
        GameObject.Find("GameTutorial").GetComponent<SpriteRenderer>().sprite = GameTutorialTur;
    }
    public void eNMenu()
    {
  
        GameObject.Find("MAPTEXT").GetComponent<TextMeshPro>().text = "MAP";
        GameObject.Find("MAPTEXT (1)").GetComponent<TextMeshPro>().text = "STATS";
        GameObject.Find("colleted").GetComponent<TextMeshPro>().text = "COLLECTED STARS:";
        GameObject.Find("sp1").GetComponent<TextMeshPro>().text = "DRAG BOMB";
        GameObject.Find("DB_info (1)").GetComponent<TextMeshPro>().text = "YOU NEED 3";
        GameObject.Find("TIme Bomb").GetComponent<TextMeshPro>().text = "TIME BOMB";
        GameObject.Find("DB_info").GetComponent<TextMeshPro>().text = "YOU NEED 4";
        GameObject.Find("TIme Bomb (1)").GetComponent<TextMeshPro>().text = "TRANSFORMER BOMB";
        GameObject.Find("DB_info (2)").GetComponent<TextMeshPro>().text = "YOU NEED 10";
        GameObject.Find("BackButton").GetComponent<TextMeshPro>().text = "BACK";
        //GameObject.Find("backButton").GetComponent<TextMeshPro>().text = "BACK";
        GameObject.Find("sure").GetComponent<TextMeshPro>().text = "ARE YOU SURE WANT TO START A NEW GAME?";
        GameObject.Find("YES").GetComponent<TextMeshPro>().text = "YES";
        GameObject.Find("NO").GetComponent<TextMeshPro>().text = "NO";
        GameObject.Find("TotalStars").GetComponent<TextMeshPro>().text = "TOTAL STARS:";
        GameObject.Find("totalExpFoodsText").GetComponent<TextMeshPro>().text = "TOTAL EXP FOODS:";
        GameObject.Find("totalExpDONUTSText").GetComponent<TextMeshPro>().text = "TOTAL EXP DONUTS:";
        GameObject.Find("totalExpEGGSText").GetComponent<TextMeshPro>().text = "TOTAL EXP EGGS:";
        GameObject.Find("totalExpMELONSText").GetComponent<TextMeshPro>().text = "TOTAL EXP MELONS:";
        GameObject.Find("totalExpCOOKIESText").GetComponent<TextMeshPro>().text = "TOTAL EXP COOKIES:";
        GameObject.Find("totalExpORANGESText").GetComponent<TextMeshPro>().text = "TOTAL EXP ORANGES:";
        GameObject.Find("totalExpBOMBSText").GetComponent<TextMeshPro>().text = "TOTAL EXP BOMBS:";
        GameObject.Find("Eliminate").GetComponent<TextMeshPro>().text = "ELIMINATE BOMB";
        GameObject.Find("DB_info (3)").GetComponent<TextMeshPro>().text = "YOU NEED 5";

        GameObject.Find("gameinfo").GetComponent<SpriteRenderer>().sprite = GameinfoEn;
        GameObject.Find("Quit_Normal 1").GetComponent<SpriteRenderer>().sprite = GameObject.Find("arkaduvar (1)").GetComponent<Language>().QuitButtonEn;
        GameObject.Find("take_Superpowers").GetComponent<SpriteRenderer>().sprite = GameObject.Find("arkaduvar (1)").GetComponent<Language>().TakeSuperPowersEn;
        GameObject.Find("NG_Normal 1").GetComponent<SpriteRenderer>().sprite = GameObject.Find("arkaduvar (1)").GetComponent<Language>().NewGameButtonEn;
        GameObject.Find("NG_Normal 1").GetComponent<New_Game_Button>().NewSprite = GameObject.Find("arkaduvar (1)").GetComponent<Language>().NewGameButtonEnPressed;
        GameObject.Find("RG_Normal").GetComponent<SpriteRenderer>().sprite = GameObject.Find("arkaduvar (1)").GetComponent<Language>().ResumeButtonEn;
        GameObject.Find("MAP").GetComponent<SpriteRenderer>().sprite = GameObject.Find("arkaduvar (1)").GetComponent<Language>().MainMapEn;
        GameObject.Find("GameTutorial").GetComponent<SpriteRenderer>().sprite = GameTutorialEn;

    }
}




