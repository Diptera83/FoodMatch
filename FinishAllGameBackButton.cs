using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishAllGameBackButton : MonoBehaviour
{
    private void OnMouseDown()
    {

        GameObject.Find("perde").transform.position = new Vector3(0.206f, 25.83f, 0);
        GameObject.Find("GameObject").GetComponent<Stats>().SaveGeneralStats();
        SceneManager.LoadScene("MainMenu");
    }
}
