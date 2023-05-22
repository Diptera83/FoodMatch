using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombscanteleportinfo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.Find("GameObject").GetComponent<LevelControl>().Level==10)
        showinfo();
    }

  
    public void showinfo()
    {
        StartCoroutine(WaitAndDestroy());

    }

    IEnumerator WaitAndDestroy()
    {
        transform.position = new Vector3(0.09f, -3.29f, 0);

        yield return new WaitForSeconds(4); // 3 saniye bekle

        transform.position = new Vector3(14.49f, -3.29f, 0);
    }

}
