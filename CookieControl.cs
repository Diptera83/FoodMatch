using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CookieControl : MonoBehaviour
{
   
    bool kapanis;
    public AudioClip r0;
    public AudioClip r1;
    public AudioClip r2;
    public AudioClip r3;
    public AudioClip r4;
    public AudioClip r5;
    public AudioClip r6;
    public AudioClip r7;
    public AudioClip r8;
    public AudioClip r9;

    List<AudioClip> rList;

    public bool isReady;
    public GameObject BuObje;
    public GameObject skorobje;
    public GameObject Cookie_Counter;
    private bool basilimi = false;
    private Vector3 mousePosition;

    public AudioClip touch1;
    public AudioClip touch2;
    public AudioClip touch3;
    public AudioClip touch4;
    bool RakamTamamlandi;
   


    int Explode_Counter;

    private Vector3 GetMouseWorldPosition() { return Camera.main.ScreenToWorldPoint(Input.mousePosition); }

    void Start()
    {
        
        transform.GetComponent<AudioSource>().Stop();
        rList = new List<AudioClip>();
        rList.Add(r0);
        rList.Add(r1);
        rList.Add(r2);
        rList.Add(r3);
        rList.Add(r4);
        rList.Add(r5);
        rList.Add(r6);
        rList.Add(r7);
        rList.Add(r8);
        rList.Add(r9);

        transform.GetComponent<AudioSource>().Stop();
        isReady = false;
        transform.Find("Particle System").GetComponent<ParticleSystem>().Stop();
        transform.Find("PLUS").GetComponent<ParticleSystem>().Stop();
        transform.Find("Particle System_2").GetComponent<ParticleSystem>().Stop();
        transform.Find("Particle System_3").GetComponent<ParticleSystem>().Stop();
        transform.Find("Particle System_4").GetComponent<ParticleSystem>().Stop();
        transform.Find("SUPER").GetComponent<ParticleSystem>().Stop();
        transform.Find("NICE").GetComponent<ParticleSystem>().Stop();
        transform.Find("PERFECT").GetComponent<ParticleSystem>().Stop();
        transform.Find("GOOD").GetComponent<ParticleSystem>().Stop();
        transform.Find("AWESOME").GetComponent<ParticleSystem>().Stop();
        transform.Find("Exp").GetComponent<ParticleSystem>().Stop();

        basilimi = false;
        transform.Find("Cookie_Counter").GetComponent<TextMeshPro>().enabled = false;
        transform.Find("Elips").GetComponent<SpriteRenderer>().enabled = false;
        Explode_Counter = 1;
    }
    void Update()
    {

    }
    private void OnMouseDown()
    {
        if (tag == "Cookie")
        {
            basilimi = true;
        }
        transform.Find("Elips").GetComponent<SpriteRenderer>().enabled = true;

        mousePosition = gameObject.transform.position - GetMouseWorldPosition();




    }



    private void OnMouseUp()
    {
        if (tag == "Cookie")
        {
            basilimi = false;
            MouseUpAnimation(Explode_Counter);
        }
        transform.Find("Elips").GetComponent<SpriteRenderer>().enabled = false;
    }
    private void OnMouseDrag()
    {
        if (tag == "Cookie")
        {

            basilimi = true;

            if (transform.position.x >= -2.56f && transform.position.x <= 2.5f)
            {
                transform.position = GetMouseWorldPosition() + mousePosition;
            }
            else
            {
                if (transform.position.x < -2.56f)
                {
                    transform.position = new Vector3(-2.55f, transform.position.y, transform.position.z);
                }
                else if (transform.position.x > 2.5f)
                {
                    transform.position = new Vector3(2.4f, transform.position.y, transform.position.z);
                }
                if (transform.position.y < -4.40)
                {
                    transform.position = new Vector3(transform.position.x, -4.39f, transform.position.z);
                }


            }
        }






    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        BuObje.transform.Find("Red_Alert").GetComponent<Animator>().SetBool("red_start", false);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
       
        if (other.relativeVelocity.magnitude>5)
        {
          
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
        }
      
        CollisionWork(other);
    }
    void OnCollisionStay2D(Collision2D other)
    {
       
        
          
        
        CollisionWork(other);


    }
    void CollisionWork(Collision2D other)
    {
        if (!basilimi && other.gameObject.tag == "bomb")
        {
            BuObje.transform.Find("Red_Alert").GetComponent<Animator>().SetBool("red_start", true);
        }

        if (!basilimi && other.gameObject.tag == "bomb")
        {
            transform.Find("Red_Alert").GetComponent<Animator>().SetBool("red_start", true);
        }
        else
        {
            transform.Find("Red_Alert").GetComponent<Animator>().SetBool("red_start", false);
        }

        if (BuObje.transform.position.y < 3.5f)
        {
            isReady = true; //Art�k �st s�n�ra de�erse oyun biter

        }
        if (isReady && BuObje.transform.position.y > 3.5f && !basilimi && other.gameObject.tag != "star_grup" && other.gameObject.tag != "speedball")
        {
            GameObject.Find("GameObject").GetComponent<Stats>().SaveGeneralStats();
            GameObject.Find("You_Lost").GetComponent<MainStarAnimes>().MoveToLost(new Vector3(0, 0, 0));
            GameObject.Find("GameObject").GetComponent<oyun>().oyunbaslasin = false;
            GameObject.Find("GameObject").GetComponent<oyun>().OyunDurdu = true;
            GameObject.Find("GameObject").GetComponent<LevelControl>().levelkaybedildi = true;
        }
        isReady = true; //Art�k �st s�n�ra de�erse oyun biter


        if (basilimi && other.gameObject.tag == "bomb")
        {
           
            other.gameObject.GetComponent<AudioSource>().Play();
            other.gameObject.GetComponent<Bomb>().startAnimation();
            Destroy(BuObje);

        }
       
        else if (basilimi && other.gameObject.tag == "speedball")
        {
            other.gameObject.GetComponent<AudioSource>().Play();
            GameObject.Find("GameObject").GetComponent<oyun>().ChangeGameSpeed50();


            other.gameObject.GetComponent<SpeedBomb>().startAnimation();
            Destroy(BuObje);
        }
       
        else
        {
            if (other.gameObject.tag == "Cookie")
            {


                if (basilimi)
                {

                    if (other.gameObject.GetComponent<CookieControl>().Explode_Counter > 1)
                    {
                        Explode_Counter = Explode_Counter + other.gameObject.GetComponent<CookieControl>().Explode_Counter;
                    }
                    else
                    {
                        Explode_Counter++;
                    }
                    if (Explode_Counter - 1 >= 0 && Explode_Counter - 1 < 10)
                    {
                        transform.GetComponent<AudioSource>().clip = rList[Explode_Counter - 1];
                        transform.GetComponent<AudioSource>().Play();
                    }
                    else
                    {
                        transform.GetComponent<AudioSource>().clip = rList[9];
                        transform.GetComponent<AudioSource>().Play();
                    }
                    transform.Find("Cookie_Counter").GetComponent<TextMeshPro>().text = Explode_Counter.ToString();
                    if (Explode_Counter >= 10 && !RakamTamamlandi)
                    {
                        GameObject.Find("GameObject").GetComponent<LevelControl>().SkorTakipcisi(skorobje, true);

                        GameObject.Find("GameObject").GetComponent<LevelControl>().PuanTopla(100);
                        GameObject.Find("CollectSounds").GetComponent<collectsoundplay>().PlayCollectSound();
                        RakamTamamlandi = true;
                    }
                    else
                    {
                        GameObject.Find("GameObject").GetComponent<LevelControl>().PuanTopla(50);
                    }

                    //BuObje.gameObject.transform.localScale = new Vector3(transform.localScale.x + 0.01f, transform.localScale.y + 0.01f, transform.localScale.z + 0.01f);

                    if (BuObje.gameObject.transform.localScale.x >= other.gameObject.transform.localScale.x)
                    {
                        BuObje.gameObject.transform.localScale = new Vector3((float)transform.localScale.x + (float)(Explode_Counter * 0.0015f), (float)transform.localScale.y + (float)(Explode_Counter * 0.0015f), (float)transform.localScale.z + (float)(Explode_Counter * 0.0015f));

                    }
                    else
                    {
                        BuObje.gameObject.transform.localScale = new Vector3((float)other.transform.localScale.x + (float)(Explode_Counter * 0.0015f), (float)other.transform.localScale.y + (float)(Explode_Counter * 0.0015f), (float)other.transform.localScale.z + (float)(Explode_Counter * 0.0015f));
                    }

                    transform.Find("Particle System").GetComponent<ParticleSystem>().Play();

                    transform.Find("Particle System_2").GetComponent<ParticleSystem>().Play();
                    transform.Find("Particle System_3").GetComponent<ParticleSystem>().Play();
                    Destroy(other.gameObject);
                    transform.Find("Cookie_Counter").GetComponent<TextMeshPro>().enabled = true;



                }


            }
        }

      
        if (Explode_Counter >= 10)
        {
        
            basilimi = false;
          
            StartCoroutine(WaitAndDestroy());

        }

        IEnumerator WaitAndDestroy()
        {
            if (!kapanis) 
            {
               
                kapanis = true;
                transform.Find("Particle System_4").GetComponent<ParticleSystem>().Play();
                
                transform.Find("Exp").GetComponent<ParticleSystem>().Play();
                yield return new WaitForSeconds(0.5f); // 1 saniye bekle
                GameObject.Find("GameObject").GetComponent<Stats>().GeneralExpFoods++;
                GameObject.Find("GameObject").GetComponent<Stats>().ExpCookie++;
                Destroy(BuObje);
            }
            

         


        }
    }

    public void MouseUpAnimation(int explode_number)
    {
        if (explode_number == 6)
        {
            transform.Find("GOOD").GetComponent<ParticleSystem>().Play();
        }
        else if (explode_number == 7)
        {
            transform.Find("NICE").GetComponent<ParticleSystem>().Play();
        }
        else if (explode_number == 8)
        {
            transform.Find("PERFECT").GetComponent<ParticleSystem>().Play();
        }
        else if (explode_number == 9)
        {
            transform.Find("AWESOME").GetComponent<ParticleSystem>().Play();
        }

    }
}
