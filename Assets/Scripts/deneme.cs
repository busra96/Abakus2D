using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deneme : MonoBehaviour
{
    private bool _selected;
    Rigidbody2D fizik;
    public float speed;
   //public float maxLimitX, minLimitX, maxLimitY;

    void Start()
    {
        fizik = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        
        if (_selected == true)
        {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        var mouseDir = mousePos - gameObject.transform.position;
        mouseDir.z = 0.0f;
        mouseDir = mouseDir.normalized;
        fizik.AddForce(mouseDir * speed);
        speed = 45 ; 
        }
    }

    //Addforce uygulanan hızı azaltıyor. Böylelikle boncukları ittikten sonra hızları yavaşlayacak ve geriye dönme işlemi az olacak
    IEnumerator hizAzalt()
    {
        yield return new WaitForSeconds(2);
        speed -= 25; ;
    }
    
   
    //void Update()
    //{

    //    if (selected == true)
    //    {
    //        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //         if(cursorPos.x <= maxLimitX && cursorPos.x >= minLimitX)
    //        {
    //            transform.position = new Vector2(cursorPos.x * speed, maxLimitY);
    //        }
    //    }
    //    if (Input.GetMouseButtonUp(0))
    //    {
    //        selected = false;
    //    }
    //}

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _selected = true;
        }
    }

    void OnMouseUp()
    {
        if(Input.GetMouseButtonUp(0))
        {
            _selected = false;

            StartCoroutine(hizAzalt());

        }
       
    }
}
