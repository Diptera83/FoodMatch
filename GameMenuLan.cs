using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameMenuLan : MonoBehaviour
{
    public string AppLan;
    public Sprite YouLostTur;
    public Sprite YouLostEn;
    public Sprite WellDoneTur;
    public Sprite WellDoneEn;
    public Sprite LevelCompleteTur;
    public Sprite LevelCompleteEn;
    public Sprite CalendarTur;
    public Sprite CalendarEn;
    public Sprite PowerUpEn;
    public Sprite PowerUpTur;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("Lan"))
        {
            AppLan = PlayerPrefs.GetString("Lan");

            if (AppLan == "En")
            {
                eNMenu();
                
            }
            else
            {
                TurMenu();
               
            }
        }
        else
        {
            eNMenu();
            PlayerPrefs.SetString("Lan", "En");
            PlayerPrefs.Save();
            AppLan = "En";
           
        }

    }

    public void TurMenu()
    {
        GameObject.Find("mainmenulost").GetComponent<TextMeshPro>().text = "ANA MENU";
        GameObject.Find("restartgamelost").GetComponent<TextMeshPro>().text = "TEKRAR OYNA";
        GameObject.Find("nextlevelwin").GetComponent<TextMeshPro>().text = "SONRAKI SEVIYE";
        GameObject.Find("mainmenuwin").GetComponent<TextMeshPro>().text = "ANA MENU";
        GameObject.Find("Exploded").GetComponent<TextMeshPro>().text = "GOREVIN:";
        
        GameObject.Find("TimeScaleInfo").GetComponent<TextMeshPro>().text = "ZAMAN OLCEGI:";
        GameObject.Find("colleted").GetComponent<TextMeshPro>().text = "TOPLAM YILDIZ";
        GameObject.Find("sp1").GetComponent<TextMeshPro>().text = "SURUKLEME BOMBASI";
        GameObject.Find("DB_info (1)").GetComponent<TextMeshPro>().text = "3 ADET LAZIM";
        GameObject.Find("TIme Bomb").GetComponent<TextMeshPro>().text = "ZAMAN BOMBASI";
        GameObject.Find("DB_info").GetComponent<TextMeshPro>().text = "4 ADET LAZIM";
        GameObject.Find("TIme Bomb (1)").GetComponent<TextMeshPro>().text = "DONUSTURUCU BOMBA";
        GameObject.Find("DB_info (2)").GetComponent<TextMeshPro>().text = "10 ADET LAZIM";
        GameObject.Find("Resume").GetComponent<TextMeshPro>().text = "DEVAM ET";
        GameObject.Find("SuperPowerMenu").GetComponent<TextMeshPro>().text = "SUPER SILAHLAR";
        GameObject.Find("GoToMenu").GetComponent<TextMeshPro>().text = "ANA MENUYE DON";
        GameObject.Find("Restart").GetComponent<TextMeshPro>().text = "YENIDEN BASLA";
        GameObject.Find("EliminateBomb_Text").GetComponent<TextMeshPro>().text = "ETKISIZLETSTIRME BOMBASI";
        GameObject.Find("DB_info_eLÝMÝNATE").GetComponent<TextMeshPro>().text = "5 ADET LAZIM";
        GameObject.Find("ObjeCountYouLost").GetComponent<TextMeshPro>().text = "TOPLAM YIYECEK";
        GameObject.Find("GameSecondsYouLost").GetComponent<TextMeshPro>().text = "TOPLAM SANIYE:";
        GameObject.Find("BombTeleportTanitim").transform.Find("Anlatim").GetComponent<TextMeshPro>().text = "SEVIYE 10";
        GameObject.Find("BombTeleportTanitim").transform.Find("Anlatim (1)").GetComponent<TextMeshPro>().text = "BOMBALAR HAREKET EDEBILIR";
        GameObject.Find("SpeedBombTanitim").transform.Find("Anlatim").GetComponent<TextMeshPro>().text = "SEVIYE 15";
        GameObject.Find("SpeedBombTanitim").transform.Find("Anlatim (1)").GetComponent<TextMeshPro>().text = "HIZ BOMBASI OYUNU HIZLANDIRABILIR";
        GameObject.Find("SpeedBombTanitim").transform.Find("Anlatim (2)").GetComponent<TextMeshPro>().text = "SAKIN DOKUNMA!";
        GameObject.Find("yazim").GetComponent<TextMeshPro>().text = "Super Silahlar için yýldýzlarý kullanýn";

        GameObject.Find("SUPERPOWERTanitim").transform.Find("Anlatim (1)").GetComponent<TextMeshPro>().text = "SUPER GUCLERINI KULLAN";
        GameObject.Find("SUPERPOWERTanitim").transform.Find("Anlatim (2)").GetComponent<TextMeshPro>().text = "OYUN MENUSUNE GOZ AT";

        GameObject.Find("DragObjectsTanitim").transform.Find("Anlatim").GetComponent<TextMeshPro>().text = "SEVIYE 1";
        GameObject.Find("DragObjectsTanitim").transform.Find("Anlatim (1)").GetComponent<TextMeshPro>().text = "OBJELERI 10 OLUNCAYA KADAR SURUKLE VE TOPLA";
        GameObject.Find("DragObjectsTanitim").transform.Find("Anlatim (2)").GetComponent<TextMeshPro>().text = "SAKIN BOMBALARA DOKUNMA!";
        GameObject.Find("videoizle").GetComponent<TextMeshPro>().text = "Videoyu izle ekstra 5 yýldýz kazan!";
        GameObject.Find("WellDone").GetComponent<TextMeshPro>().text = "TEBRIKLER";
        GameObject.Find("WellDone (1)").GetComponent<TextMeshPro>().text = "SEVIYE TAMAMLANDI";

        GameObject.Find("main_star_lost").GetComponent<SpriteRenderer>().sprite = YouLostTur;
       
      
        GameObject.Find("D A Y").GetComponent<SpriteRenderer>().sprite = CalendarTur;
    }
    public void eNMenu()
    {
        GameObject.Find("mainmenulost").GetComponent<TextMeshPro>().text = "MAIN MENU";
        GameObject.Find("restartgamelost").GetComponent<TextMeshPro>().text = "RESTART LEVEL";
        GameObject.Find("nextlevelwin").GetComponent<TextMeshPro>().text = "NEXT LEVEL";
        GameObject.Find("mainmenuwin").GetComponent<TextMeshPro>().text = "MAIN MENU";
        GameObject.Find("Exploded").GetComponent<TextMeshPro>().text = "YOUR MISSION:";
        
        GameObject.Find("TimeScaleInfo").GetComponent<TextMeshPro>().text = "TIMESCALE:";
        GameObject.Find("colleted").GetComponent<TextMeshPro>().text = "COLLECTED STARS:";
        GameObject.Find("sp1").GetComponent<TextMeshPro>().text = "DRAG BOMB";
        GameObject.Find("DB_info (1)").GetComponent<TextMeshPro>().text = "YOU NEED 3";
        GameObject.Find("TIme Bomb").GetComponent<TextMeshPro>().text = "TIME BOMB";
        GameObject.Find("DB_info").GetComponent<TextMeshPro>().text = "YOU NEED 4";
        GameObject.Find("TIme Bomb (1)").GetComponent<TextMeshPro>().text = "TRANSFORMER BOMB";
        GameObject.Find("DB_info (2)").GetComponent<TextMeshPro>().text = "YOU NEED 10";
        GameObject.Find("Resume").GetComponent<TextMeshPro>().text = "RESUME";
        GameObject.Find("SuperPowerMenu").GetComponent<TextMeshPro>().text = "SUPER POWERS";
        GameObject.Find("GoToMenu").GetComponent<TextMeshPro>().text = "GO TO MAIN MENU";
        GameObject.Find("Restart").GetComponent<TextMeshPro>().text = "RESTART GAME";
      
        GameObject.Find("ObjeCountYouLost").GetComponent<TextMeshPro>().text = "Total Foods:";
        GameObject.Find("GameSecondsYouLost").GetComponent<TextMeshPro>().text = "Total Sec:";

        GameObject.Find("videoizle").GetComponent<TextMeshPro>().text = "Watch the video to get extra 5 stars!";
        GameObject.Find("EliminateBomb_Text").GetComponent<TextMeshPro>().text = "ELIMINATE BOMB";
        GameObject.Find("DB_info_eLÝMÝNATE").GetComponent<TextMeshPro>().text = "YOU NEED 5";
        GameObject.Find("yazim").GetComponent<TextMeshPro>().text = "use stars for super powers";

        GameObject.Find("BombTeleportTanitim").transform.Find("Anlatim").GetComponent<TextMeshPro>().text = "LEVEL 10";
        GameObject.Find("BombTeleportTanitim").transform.Find("Anlatim (1)").GetComponent<TextMeshPro>().text = "BOMBS MOVE ANY PLACE";
        GameObject.Find("SpeedBombTanitim").transform.Find("Anlatim").GetComponent<TextMeshPro>().text = "LEVEL 15";
        GameObject.Find("SpeedBombTanitim").transform.Find("Anlatim (1)").GetComponent<TextMeshPro>().text = "SPEED BOMB CAN SPEED UP THE GAME";
        GameObject.Find("SpeedBombTanitim").transform.Find("Anlatim (2)").GetComponent<TextMeshPro>().text = "DON'T TOUCH IT!";

        GameObject.Find("DragObjectsTanitim").transform.Find("Anlatim").GetComponent<TextMeshPro>().text = "LEVEL 1";
        GameObject.Find("DragObjectsTanitim").transform.Find("Anlatim (1)").GetComponent<TextMeshPro>().text = "DRAG AND COLLECT THE SAME 10 OBJECTS";
        GameObject.Find("DragObjectsTanitim").transform.Find("Anlatim (2)").GetComponent<TextMeshPro>().text = "DON'T TOUCH THE BOMBS";

        
        GameObject.Find("main_star_lost").GetComponent<SpriteRenderer>().sprite = YouLostEn;
        GameObject.Find("WellDone").GetComponent<TextMeshPro>().text = "WELL DONE";
        GameObject.Find("WellDone (1)").GetComponent<TextMeshPro>().text = "LEVEL COMPLETE";
        //GameObject.Find("WELL DONE").GetComponent<SpriteRenderer>().sprite = WellDoneEn;
        //GameObject.Find("LEVEL COMPLETE").GetComponent<SpriteRenderer>().sprite = LevelCompleteEn;
        GameObject.Find("D A Y").GetComponent<SpriteRenderer>().sprite = CalendarEn;
    }
}
