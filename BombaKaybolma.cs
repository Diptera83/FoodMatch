using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombaKaybolma : MonoBehaviour
{
    private Animator mAnimator;
    // Start is called before the first frame update
    void Start()
    {
        mAnimator = GetComponent<Animator>();
    }


    public void t1anime()
    {
        mAnimator.SetTrigger("Kaybol");
    }

    public void t2anime()
    {
        mAnimator.SetTrigger("Ayil");
    }
}
