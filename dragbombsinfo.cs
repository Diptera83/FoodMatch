using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragbombsinfo : MonoBehaviour
{
  


    public void showinfo()
    {
        StartCoroutine(WaitAndDestroy());

    }

    IEnumerator WaitAndDestroy()
    {
        transform.position = new Vector3(0.09f, -3.29f, 0);

        yield return new WaitForSeconds(4); // 3 saniye bekle

        transform.position = new Vector3(22.82f, -3.29f, 0);
    }
}
