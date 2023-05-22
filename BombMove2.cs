using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombMove2 : MonoBehaviour
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
        if (tag == "speedball" && BombActivated)
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
        if (tag == "speedball")
        {
            transform.Find("Elips").GetComponent<SpriteRenderer>().enabled = false;

        }

    }
    private void OnMouseDrag()
    {
        if (tag == "speedball" && BombActivated)
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
