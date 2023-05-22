using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Bomb : MonoBehaviour
{


    int xforce;
    int yforce;
    public int saniye;
    public AudioClip foodexp1;
    public AudioClip foodexp2;
    public AudioClip foodexp3;
    public AudioClip foodexp4;
    public AudioClip foodexp5;
    public AudioClip foodexp6;
    public AudioClip foodexp7;
    public AudioClip foodexp8;
    public AudioClip foodexp9;
    public AudioClip foodexp10;
    public AudioClip foodexp11;

    private void Start()
    {
        transform.Find("Drag_Bomb_Effect").GetComponent<ParticleSystem>().Stop();
        transform.Find("Particle System").GetComponent<ParticleSystem>().Stop();
        transform.Find("Particle System_1").GetComponent<ParticleSystem>().Stop();
        transform.Find("Particle System_2").GetComponent<ParticleSystem>().Stop();
        transform.Find("Particle_System_Apex").GetComponent<ParticleSystem>().Stop();
        transform.Find("Particle_System_Apex_2").GetComponent<ParticleSystem>().Stop();
        transform.Find("explosionum").GetComponent<ParticleSystem>().Stop();
        saniye = (int)Time.time;



    }

    private void Update()
    {

        if (transform.position.y >= 2)
        {
            transform.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -10));
        }




    }


    public GameObject BuObje;

    private void OnMouseDown()
    {
        if (!GameObject.Find("BombDrag").GetComponent<DragBombActivate>().DevamEdiyormu)
        {
            if (GameObject.Find("GameObject").GetComponent<oyun>().Black_Cube_Bomb())
            {
                GetComponent<CircleCollider2D>().enabled = false;
                transform.Find("Bomba_Patlar").GetComponent<AudioSource>().Play();
                StartCoroutine(WaitAndDestroy());



            }
            else
            {
                StartCoroutine(WaitandShowRed());

            }

        }




    }

    IEnumerator WaitandShowRed()
    {
        
        GameObject.Find("Bombs_Count").GetComponent<TextMeshPro>().color = Color.red;
        yield return new WaitForSeconds(1); // 1 saniye bekle
        GameObject.Find("Bombs_Count").GetComponent<TextMeshPro>().color = Color.white;
    }

    IEnumerator WaitAndDestroy()
    {

        transform.Find("Particle_System_Apex").GetComponent<ParticleSystem>().Play();
        transform.Find("Particle_System_Apex_2").GetComponent<ParticleSystem>().Play();

        transform.Find("explosionum").GetComponent<ParticleSystem>().Play();
        yield return new WaitForSeconds(2); // 1 saniye bekle

        GameObject.Find("GameObject").GetComponent<Stats>().ExBomb++;
        Destroy(BuObje);


    }

    public void startAnimation()
    {

        switch (new System.Random().Next(1, 11))
        {
            case 1: transform.GetComponent<AudioSource>().clip = foodexp1; break;
            case 2: transform.GetComponent<AudioSource>().clip = foodexp2; break;
            case 3: transform.GetComponent<AudioSource>().clip = foodexp3; break;
            case 4: transform.GetComponent<AudioSource>().clip = foodexp4; break;
            case 5: transform.GetComponent<AudioSource>().clip = foodexp5; break;
            case 6: transform.GetComponent<AudioSource>().clip = foodexp1; break;
            case 7: transform.GetComponent<AudioSource>().clip = foodexp2; break;
            case 8: transform.GetComponent<AudioSource>().clip = foodexp3; break;
            case 9: transform.GetComponent<AudioSource>().clip = foodexp4; break;
            case 10: transform.GetComponent<AudioSource>().clip = foodexp5; break;
            case 11: transform.GetComponent<AudioSource>().clip = foodexp5; break;
            default:
                break;
        }
        GameObject.Find("Bombcrashaudio").GetComponent<BombCrash>().crashaudio();
        transform.GetComponent<AudioSource>().Play();
        GameObject.Find("GameObject").GetComponent<oyun>().laugh++;
        if (GameObject.Find("GameObject").GetComponent<oyun>().laugh==5)
        {
            GameObject.Find("laughses").GetComponent<AudioSource>().Play();
            GameObject.Find("GameObject").GetComponent<oyun>().laugh = 0;
        }
        GameObject.Find("t1").GetComponent<tavaEffect>().t1anime();
        GameObject.Find("t2").GetComponent<tavaEffect2>().t2anime();
        GameObject.Find("t3").GetComponent<tavaEffect3>().t3anime();
        transform.Find("Particle System").GetComponent<ParticleSystem>().Play();
        transform.Find("Particle System_1").GetComponent<ParticleSystem>().Play();
        transform.Find("Particle System_2").GetComponent<ParticleSystem>().Play();
        GameObject.Find("Main Camera").GetComponent<MainCameraShake>().shakeScreen();

    }



    void BombManager()
    {

        transform.GetComponent<Rigidbody2D>().AddForce(new Vector2(new System.Random().Next(-1000, 1000), new System.Random().Next(-1000, 1000)));

    }



}