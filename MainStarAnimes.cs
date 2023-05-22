using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainStarAnimes : MonoBehaviour
{
    public float speed = 1f;
    private Vector3 _targetPosition;
    public GameObject TotalFoodYouLost;
    public GameObject TotalSecYouLost;
    public GameObject TotalFoodYouWin;
    public GameObject TotalSecYouWin;
   public bool You_Lost_Music_is_Played;
    // Start is called before the first frame update
    void Start()
    {
        _targetPosition = transform.position;
        You_Lost_Music_is_Played = false;

    }
    public void MoveTo(Vector3 position)
    {
        _targetPosition = position;
        transform.Find("lastscore").GetComponent<TextMeshPro>().text = "Score: " + GameObject.Find("GameObject").GetComponent<LevelControl>().ToplamPuan.ToString();
        TotalFoodYouWin.GetComponent<TextMeshPro>().text = "Total Foods: " + GameObject.Find("GameObject").GetComponent<oyun>().ObjeCount.ToString();
        TotalSecYouWin.GetComponent<TextMeshPro>().text = "Total Sec: " + ((int)Time.time).ToString();
    }
    public void MoveToLost(Vector3 position)
    {
        Time.timeScale = 1;
        _targetPosition = position;
        TotalFoodYouLost.GetComponent<TextMeshPro>().text = "Total Foods: " + GameObject.Find("GameObject").GetComponent<oyun>().ObjeCount.ToString();
        TotalSecYouLost.GetComponent<TextMeshPro>().text = "Total Sec: " + ((int)Time.time).ToString();
        if (!You_Lost_Music_is_Played)
        {
            if (!GameObject.Find("Table").GetComponent<AudioSource>().isPlaying)
            {
                GameObject.Find("Table").GetComponent<AudioSource>().Play();
                You_Lost_Music_is_Played = true;
            }
           
        }
        
    }
    public void MoveToCookie(Vector3 position)
    {
        _targetPosition = position;
    }
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _targetPosition, speed * 12 * Time.deltaTime);


    }



}

