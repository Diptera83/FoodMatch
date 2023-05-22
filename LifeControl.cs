using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LifeControl : MonoBehaviour
{
    public int life;
    // Start is called before the first frame update
    void Start()
    {
        life = 10;

        transform.Find("cat1").transform.position = new Vector3(0.578f, -4.789f, 0);
        transform.Find("cat2").transform.position = new Vector3(0.578f, -4.789f, 0);
        transform.Find("cat3").transform.position = new Vector3(0.578f, -4.789f, 0);
        transform.Find("cat4").transform.position = new Vector3(0.578f, -4.789f, 0);
        transform.Find("cat5").transform.position = new Vector3(0.578f, -4.789f, 0);
        transform.Find("cat6").transform.position = new Vector3(0.578f, -4.789f, 0);
        transform.Find("cat7").transform.position = new Vector3(0.578f, -4.789f, 0);
        transform.Find("cat8").transform.position = new Vector3(0.578f, -4.789f, 0);
        transform.Find("cat9").transform.position = new Vector3(0.578f, -4.789f, 0);
        transform.Find("cat10").transform.position = new Vector3(0.578f, -4.789f, 0);
        //----------------------------------------------------------------------------------------
        transform.Find("cat1").GetComponent<Rigidbody2D>().gravityScale = 0;
        transform.Find("cat2").GetComponent<Rigidbody2D>().gravityScale = 0;
        transform.Find("cat3").GetComponent<Rigidbody2D>().gravityScale = 0;
        transform.Find("cat4").GetComponent<Rigidbody2D>().gravityScale = 0;
        transform.Find("cat5").GetComponent<Rigidbody2D>().gravityScale = 0;
        transform.Find("cat6").GetComponent<Rigidbody2D>().gravityScale = 0;
        transform.Find("cat7").GetComponent<Rigidbody2D>().gravityScale = 0;
        transform.Find("cat8").GetComponent<Rigidbody2D>().gravityScale = 0;
        transform.Find("cat9").GetComponent<Rigidbody2D>().gravityScale = 0;
        transform.Find("cat10").GetComponent<Rigidbody2D>().gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OneLifeDown()
    {
        life--;
        if (GameObject.Find("arkaduvar").GetComponent<GameMenuLan>().AppLan == "En")
        {
            transform.Find("LifeCountText").GetComponent<TextMeshPro>().text = "Your Life: " + life.ToString();
        }
        else
        {
            transform.Find("LifeCountText").GetComponent<TextMeshPro>().text = "Can Hakkýn: " + life.ToString();
        }
        
         if (life == 9)
        {
            transform.Find("cat1").transform.position = new Vector3(0.578f, -4.789f, 0);
            transform.Find("cat2").transform.position = new Vector3(0.578f, -4.789f, 0);
            transform.Find("cat3").transform.position = new Vector3(0.578f, -4.789f, 0);
            transform.Find("cat4").transform.position = new Vector3(0.578f, -4.789f, 0);
            transform.Find("cat5").transform.position = new Vector3(0.578f, -4.789f, 0);
            transform.Find("cat6").transform.position = new Vector3(0.5789f, -4.789f, 0);
            transform.Find("cat7").transform.position = new Vector3(0.578f, -4.789f, 0);
            transform.Find("cat8").transform.position = new Vector3(0.578f, -4.789f, 0);
            transform.Find("cat9").transform.position = new Vector3(0.578f, -4.789f, 0);

            transform.Find("cat10").transform.rotation = Quaternion.Euler(0, 0, -180); transform.Find("cat10").GetComponent<Rigidbody2D>().gravityScale = 0.2f;

        }
        else if (life == 8)
        {
            transform.Find("cat1").transform.position = new Vector3(0.578f, -4.789f, 0);
            transform.Find("cat2").transform.position = new Vector3(0.578f, -4.789f, 0);
            transform.Find("cat3").transform.position = new Vector3(0.578f, -4.789f, 0);
            transform.Find("cat4").transform.position = new Vector3(0.578f, -4.789f, 0);
            transform.Find("cat5").transform.position = new Vector3(0.578f, -4.789f, 0);
            transform.Find("cat6").transform.position = new Vector3(0.578f, -4.789f, 0);
            transform.Find("cat7").transform.position = new Vector3(0.578f, -4.789f, 0);
            transform.Find("cat8").transform.position = new Vector3(0.578f, -4.789f, 0);

            transform.Find("cat9").transform.rotation = Quaternion.Euler(0, 0, -180); transform.Find("cat9").GetComponent<Rigidbody2D>().gravityScale = 0.2f;
            
        }
        else if (life == 7)
        {
            transform.Find("cat1").transform.position = new Vector3(0.578f, -4.789f, 0);
            transform.Find("cat2").transform.position = new Vector3(0.578f, -4.789f, 0);
            transform.Find("cat3").transform.position = new Vector3(0.578f, -4.789f, 0);
            transform.Find("cat4").transform.position = new Vector3(0.578f, -4.789f, 0);
            transform.Find("cat5").transform.position = new Vector3(0.578f, -4.789f, 0);
            transform.Find("cat6").transform.position = new Vector3(0.578f, -4.789f, 0);
            transform.Find("cat7").transform.position = new Vector3(0.578f, -4.789f, 0);
          

            transform.Find("cat8").transform.rotation = Quaternion.Euler(0, 0, -180); transform.Find("cat8").GetComponent<Rigidbody2D>().gravityScale = 0.2f;
        }
        else if (life == 6)
        {
            transform.Find("cat1").transform.position = new Vector3(0.5781f, -4.789f, 0);
            transform.Find("cat2").transform.position = new Vector3(0.578f, -4.789f, 0);
            transform.Find("cat3").transform.position = new Vector3(0.578f, -4.789f, 0);
            transform.Find("cat4").transform.position = new Vector3(0.578f, -4.789f, 0);
            transform.Find("cat5").transform.position = new Vector3(0.578f, -4.789f, 0);
            transform.Find("cat6").transform.position = new Vector3(0.578f, -4.789f, 0);

            transform.Find("cat7").transform.rotation = Quaternion.Euler(0, 0, -180); transform.Find("cat7").GetComponent<Rigidbody2D>().gravityScale = 0.2f;
        }
        else if (life == 5) 
        {
            transform.Find("cat1").transform.position = new Vector3(0.578f, -4.789f, 0);
            transform.Find("cat2").transform.position = new Vector3(0.5783f, -4.789f, 0);
            transform.Find("cat3").transform.position = new Vector3(0.578f, -4.789f, 0);
            transform.Find("cat4").transform.position = new Vector3(0.578f, -4.789f, 0);
            transform.Find("cat5").transform.position = new Vector3(0.578f, -4.789f, 0);

            transform.Find("cat6").transform.rotation = Quaternion.Euler(0, 0, -180); transform.Find("cat6").GetComponent<Rigidbody2D>().gravityScale = 0.2f;

        }
        else if (life == 4)
        {
            transform.Find("cat1").transform.position = new Vector3(0.578f, -4.789f, 0);
            transform.Find("cat2").transform.position = new Vector3(0.578f, -4.789f, 0);
            transform.Find("cat3").transform.position = new Vector3(0.578f, -4.789f, 0);
            transform.Find("cat4").transform.position = new Vector3(0.578f, -4.789f, 0);
         

            transform.Find("cat5").transform.rotation = Quaternion.Euler(0, 0, -180); transform.Find("cat5").GetComponent<Rigidbody2D>().gravityScale = 0.2f;

        }
        else if (life == 3)
        {
            transform.Find("cat1").transform.position = new Vector3(0.578f, -4.789f, 0);
            transform.Find("cat2").transform.position = new Vector3(0.578f, -4.789f, 0);
            transform.Find("cat3").transform.position = new Vector3(0.578f, -4.789f, 0);
    


            transform.Find("cat4").transform.rotation = Quaternion.Euler(0, 0, -180); transform.Find("cat4").GetComponent<Rigidbody2D>().gravityScale = 0.2f;

        }
        else if (life == 2)
        {
            transform.Find("cat1").transform.position = new Vector3(0.578f, -4.789f, 0);
            transform.Find("cat2").transform.position = new Vector3(0.578f, -4.789f, 0);
          



            transform.Find("cat3").transform.rotation = Quaternion.Euler(0, 0, -180); transform.Find("cat3").GetComponent<Rigidbody2D>().gravityScale = 0.2f;

        }
        else if (life == 1)
        {
            transform.Find("cat1").transform.position = new Vector3(0.578f, -4.789f, 0);
          




            transform.Find("cat2").transform.rotation = Quaternion.Euler(0, 0, -180); transform.Find("cat2").GetComponent<Rigidbody2D>().gravityScale = 0.2f;

        }
        else if (life == 0) 
        {
            transform.Find("cat1").transform.rotation = Quaternion.Euler(0, 0, -180); transform.Find("cat1").GetComponent<Rigidbody2D>().gravityScale = 0.2f;
        }
    }
}
