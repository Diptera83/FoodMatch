using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BombMove : MonoBehaviour
{
    public bool BombActivated;

    private Vector3 mousePosition;
    int Explode_Counter;
   
  
  
    private Vector3 GetMouseWorldPosition() { return Camera.main.ScreenToWorldPoint(Input.mousePosition); }
   
    void Start()
    {
       
      
        
      
        transform.Find("Elips").GetComponent<SpriteRenderer>().enabled = false;
        BombActivated = false;
    }

   
    void Update()
    {
      
    
          
        
    }
  
   

   

    private void OnMouseDown()
    {
        
        if (tag == "bomb")
        {

          
            transform.Find("Elips").GetComponent<SpriteRenderer>().enabled = true;

            mousePosition = gameObject.transform.position - GetMouseWorldPosition();
        }
        else
        {
            transform.Find("Elips").GetComponent<SpriteRenderer>().enabled = false;
        }


    }

    private void OnMouseUp()
    {
        if (tag == "bomb")
        {
           
            transform.Find("Elips").GetComponent<SpriteRenderer>().enabled = false;

        }

    }
    private void OnMouseDrag()
    {
        if (tag == "bomb" && BombActivated)
        {

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



}
