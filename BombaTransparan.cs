using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombaTransparan : MonoBehaviour
{
    private Animator mAnimator;
    // Start is called before the first frame update
    void Start()
    {
        mAnimator= GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartTrans()
    {
        mAnimator.SetBool("bomb_trans", true);
    }
    public void StopTrans()
    {
        mAnimator.SetBool("bomb_trans", false);
    }
}
