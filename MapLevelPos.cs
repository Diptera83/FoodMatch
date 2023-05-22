using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MapLevelPos : MonoBehaviour
{
    // Start is called before the first frame update
    public int Level;
    public int RealLevel;
    public int RealChapter;
 

    public void LevelMarker()
    {
        //PlayerPrefs.DeleteKey("SavedLevel");
        //PlayerPrefs.DeleteKey("SavedLevel_Real");
        ////PlayerPrefs.SetInt("SavedLevel", 45);
        //PlayerPrefs.SetInt("SavedLevel_Real", 75);
        ////PlayerPrefs.SetInt("SavedStars", 100);
        //PlayerPrefs.Save();
        Level = PlayerPrefs.GetInt("SavedLevel");
        RealLevel = PlayerPrefs.GetInt("SavedLevel_Real");
        RealChapter = (int)Mathf.Floor(RealLevel / 10);
        LevelCloser();
        MarkCloser();
        
        Level = PlayerPrefs.GetInt("SavedLevel");
        if (RealLevel > 0 && RealLevel < 10)
        {
            GameObject.Find("c1").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c1").GetComponent<TextMeshPro>().text = RealLevel + "/" + "10";
            GameObject.Find("m1").GetComponent<SpriteRenderer>().enabled = true;

        }
        else if (RealLevel >= 10 && RealLevel < 20)
        {
            GameObject.Find("c1").GetComponent<TextMeshPro>().text ="10/10";
            GameObject.Find("c2").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c2").GetComponent<TextMeshPro>().text = RealLevel % 10 + "/" + "10";
            GameObject.Find("m2").GetComponent<SpriteRenderer>().enabled = true;

        }
        else if (RealLevel >= 20 && RealLevel < 30)
        {
            GameObject.Find("c1").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c2").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c3").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c3").GetComponent<TextMeshPro>().text = RealLevel % 10 + "/" + "10";
            GameObject.Find("m3").GetComponent<SpriteRenderer>().enabled = true;
        }
        else if (RealLevel >= 30 && RealLevel < 40)
        {
            GameObject.Find("c1").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c2").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c3").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c4").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c4").GetComponent<TextMeshPro>().text = RealLevel % 10 + "/" + "10";
            GameObject.Find("m4").GetComponent<SpriteRenderer>().enabled = true;
        }
        else if (RealLevel >= 40 && RealLevel < 50)
        {
            GameObject.Find("c1").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c2").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c3").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c4").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c5").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c5").GetComponent<TextMeshPro>().text = RealLevel % 10 + "/" + "10";
            GameObject.Find("m5").GetComponent<SpriteRenderer>().enabled = true;
        }
        else if (RealLevel >= 50 && RealLevel < 60)
        {
            GameObject.Find("c1").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c2").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c3").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c4").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c5").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c6").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c6").GetComponent<TextMeshPro>().text = RealLevel % 10 + "/" + "10";
            GameObject.Find("m6").GetComponent<SpriteRenderer>().enabled = true;
        }
        else if (RealLevel >= 60 && RealLevel < 70)
        {
            GameObject.Find("c1").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c2").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c3").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c4").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c5").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c6").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c7").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c7").GetComponent<TextMeshPro>().text = RealLevel % 10 + "/" + "10";
            GameObject.Find("m7").GetComponent<SpriteRenderer>().enabled = true;
        }
        else if (RealLevel >= 70 && RealLevel < 80)
        {
            GameObject.Find("c1").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c2").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c3").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c4").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c5").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c6").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c7").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c8").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c8").GetComponent<TextMeshPro>().text = RealLevel % 10 + "/" + "10";
            GameObject.Find("m8").GetComponent<SpriteRenderer>().enabled = true;
        }
        else if (RealLevel >= 80 && RealLevel < 90)
        {
            GameObject.Find("c1").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c2").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c3").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c4").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c5").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c6").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c7").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c8").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c9").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c9").GetComponent<TextMeshPro>().text = RealLevel % 10 + "/" + "10";
            GameObject.Find("m9").GetComponent<SpriteRenderer>().enabled = true;
        }
        else if (RealLevel >= 90 && RealLevel <= 100)
        {
            GameObject.Find("c1").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c2").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c3").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c4").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c5").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c6").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c7").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c8").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c9").GetComponent<TextMeshPro>().text = "10/10";
            if (Level == 100)
            {
                GameObject.Find("c10").GetComponent<TextMeshPro>().enabled = true;
                GameObject.Find("c10").GetComponent<TextMeshPro>().text = "10/10";

            }
            else
            {
                GameObject.Find("c10").GetComponent<TextMeshPro>().enabled = true;
                GameObject.Find("c10").GetComponent<TextMeshPro>().text = RealLevel % 10 + "/" + "10";
            }
            GameObject.Find("m10").GetComponent<SpriteRenderer>().enabled = true;
        }
        
    }

    void LevelCloser()
    {
        GameObject.Find("c1").GetComponent<TextMeshPro>().enabled = false;
        GameObject.Find("c1").GetComponent<BoxCollider2D>().enabled = false;
        GameObject.Find("c2").GetComponent<TextMeshPro>().enabled = false;
        GameObject.Find("c2").GetComponent<BoxCollider2D>().enabled = false;
        GameObject.Find("c3").GetComponent<TextMeshPro>().enabled = false;
        GameObject.Find("c3").GetComponent<BoxCollider2D>().enabled = false;
        GameObject.Find("c4").GetComponent<TextMeshPro>().enabled = false;
        GameObject.Find("c4").GetComponent<BoxCollider2D>().enabled = false;
        GameObject.Find("c5").GetComponent<TextMeshPro>().enabled = false;
        GameObject.Find("c5").GetComponent<BoxCollider2D>().enabled = false;
        GameObject.Find("c6").GetComponent<TextMeshPro>().enabled = false;
        GameObject.Find("c6").GetComponent<BoxCollider2D>().enabled = false;
        GameObject.Find("c7").GetComponent<TextMeshPro>().enabled = false;
        GameObject.Find("c7").GetComponent<BoxCollider2D>().enabled = false;
        GameObject.Find("c8").GetComponent<TextMeshPro>().enabled = false;
        GameObject.Find("c8").GetComponent<BoxCollider2D>().enabled = false;
        GameObject.Find("c9").GetComponent<TextMeshPro>().enabled = false;
        GameObject.Find("c9").GetComponent<BoxCollider2D>().enabled = false;
        GameObject.Find("c10").GetComponent<TextMeshPro>().enabled = false;
        GameObject.Find("c10").GetComponent<BoxCollider2D>().enabled = false;
    }
    void MarkCloser()
    {
        GameObject.Find("m1").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.Find("m2").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.Find("m3").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.Find("m4").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.Find("m5").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.Find("m6").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.Find("m7").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.Find("m8").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.Find("m9").GetComponent<SpriteRenderer>().enabled = false;
        GameObject.Find("m10").GetComponent<SpriteRenderer>().enabled = false;
    }
   public void RealChapterPrepaire()
    {
        if (RealChapter == 1 )
        {
            GameObject.Find("c1").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c1").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c1").GetComponent<BoxCollider2D>().enabled = true;
        }
        else if (RealChapter == 2)
        {
            GameObject.Find("c1").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c1").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c1").GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("c2").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c2").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c2").GetComponent<BoxCollider2D>().enabled = true;
        }
        else if (RealChapter == 3)
        {
            GameObject.Find("c1").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c1").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c1").GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("c2").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c2").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c2").GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("c3").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c3").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c3").GetComponent<BoxCollider2D>().enabled = true;
        }
        else if (RealChapter == 4)
        {
            GameObject.Find("c1").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c1").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c1").GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("c2").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c2").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c2").GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("c3").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c3").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c3").GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("c4").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c4").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c4").GetComponent<BoxCollider2D>().enabled = true;
        }
        else if (RealChapter == 5)
        {
            GameObject.Find("c1").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c1").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c1").GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("c2").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c2").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c2").GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("c3").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c3").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c3").GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("c4").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c4").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c4").GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("c5").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c5").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c5").GetComponent<BoxCollider2D>().enabled = true;
        }
        else if (RealChapter == 6)
        {
            GameObject.Find("c1").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c1").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c1").GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("c2").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c2").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c2").GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("c3").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c3").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c3").GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("c4").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c4").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c4").GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("c5").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c5").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c5").GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("c6").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c6").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c6").GetComponent<BoxCollider2D>().enabled = true;
        }
        else if (RealChapter == 7)
        {
            GameObject.Find("c1").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c1").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c1").GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("c2").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c2").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c2").GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("c3").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c3").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c3").GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("c4").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c4").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c4").GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("c5").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c5").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c5").GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("c6").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c6").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c6").GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("c7").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c7").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c7").GetComponent<BoxCollider2D>().enabled = true;
        }
        else if (RealChapter == 8)
        {
            GameObject.Find("c1").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c1").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c1").GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("c2").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c2").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c2").GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("c3").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c3").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c3").GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("c4").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c4").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c4").GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("c5").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c5").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c5").GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("c6").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c6").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c6").GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("c7").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c7").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c7").GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("c8").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c8").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c8").GetComponent<BoxCollider2D>().enabled = true;
        }
        else if (RealChapter == 9)
        {
            GameObject.Find("c1").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c1").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c1").GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("c2").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c2").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c2").GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("c3").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c3").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c3").GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("c4").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c4").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c4").GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("c5").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c5").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c5").GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("c6").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c6").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c6").GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("c7").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c7").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c7").GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("c8").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c8").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c8").GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("c9").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c9").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c9").GetComponent<BoxCollider2D>().enabled = true;
        }
        else if (RealChapter >= 10)
        {
            GameObject.Find("c1").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c1").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c1").GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("c2").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c2").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c2").GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("c3").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c3").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c3").GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("c4").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c4").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c4").GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("c5").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c5").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c5").GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("c6").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c6").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c6").GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("c7").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c7").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c7").GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("c8").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c8").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c8").GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("c9").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c9").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c9").GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("c10").GetComponent<TextMeshPro>().enabled = true;
            GameObject.Find("c10").GetComponent<TextMeshPro>().text = "10/10";
            GameObject.Find("c10").GetComponent<BoxCollider2D>().enabled = true;
        }
    }
}

