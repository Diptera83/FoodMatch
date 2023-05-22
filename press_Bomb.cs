using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class press_Bomb : MonoBehaviour
{
    private Animator mAnimator;
    // Start is called before the first frame update
    void Start()
    {
        mAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AnimasyonBaslasin()
    {
        GameObject.Find("BombsText").GetComponent<MeshRenderer>().enabled = true;
        GameObject.Find("BombsText").GetComponent<TextMeshPro>().text = "PRESS THE BLACK BOMB";
        mAnimator.SetTrigger("basla");
    }

    public void AnimasyonDursun()
    {
        GameObject.Find("BombsText").GetComponent<MeshRenderer>().enabled = false;
        mAnimator.SetTrigger("bit");
    }

   
}
