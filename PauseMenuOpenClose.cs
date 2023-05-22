using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuOpenClose : MonoBehaviour
{
    public float speed = 30f;
    private Vector3 _targetPosition;


    // Start is called before the first frame update
    void Start()
    {
        _targetPosition = transform.position;

    }
    public void MoveTo(Vector3 position)
    {
       
            _targetPosition = position;


    }


    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _targetPosition, speed * 50 * Time.deltaTime);

        


    }
}
