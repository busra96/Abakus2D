using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{

    //[SerializeField]
    //private int deger;
    //public float speed;
    //public float screenLimit;
    //Vector3 mouse;

    
    void Update()
    {

        //mouse  = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        StartCoroutine("hareket");
        
    }

    IEnumerator hareket()
    {
        if (Input.GetMouseButton(0))
        {
            //transform.position = new Vector2(mouse.x * speed, screenLimit);

            Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = objPosition;

        }
        yield return null;
    }
}
