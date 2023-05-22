using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YildizAnime : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.Find("Particle System").GetComponent<ParticleSystem>().Stop();
    }

    public void YildizAnimeStart()
    {
        transform.Find("Particle System").GetComponent<ParticleSystem>().Play();
    }
}
