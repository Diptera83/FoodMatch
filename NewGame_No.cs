using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGame_No : MonoBehaviour
{
    public Sprite OldSprite;
    private void OnMouseDown()
    {
        transform.Find("Particle System").GetComponent<ParticleSystem>().Play();
        if (!transform.GetComponent<AudioSource>().isPlaying)
        {
            transform.GetComponent<AudioSource>().Play();
        }
        //GameObject.Find("NG_Normal 1").GetComponent<SpriteRenderer>().sprite=OldSprite;
        GameObject.Find("AreYouSureForNewGame").GetComponent<AreYouSureCall>().MoveTo(new Vector3(-0.14f, 11.17f, 0));
        GameObject.Find("perde").transform.position = new Vector3(0, 20.42f, 0);
        StartCoroutine(WaitAndWork());
    }

    private void Start()
    {
        transform.Find("Particle System").GetComponent<ParticleSystem>().Stop();
        transform.GetComponent<AudioSource>().Stop();

    }


    IEnumerator WaitAndWork()
    {
        yield return new WaitForSeconds(1); // 1 saniye bekle
        GameObject.Find("AreYouSureForNewGame").GetComponent<AreYouSureCall>().MoveTo(new Vector3(-0.14f, -2.77f, 0));

    }

}

