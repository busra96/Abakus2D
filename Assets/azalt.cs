using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class azalt : MonoBehaviour
{
    private GameObject boncuk;
    public bool carpismaVar = false;

    void Start()
    {
        boncuk = GameObject.FindWithTag("boncuk");
    }


    void OnCollisionEnter2D(Collision2D carp)
    {
        if(carp.gameObject.tag == "boncuk")
        {
            carpismaVar = true;
        }
        else
        {
            carpismaVar = false;
        }
    }

    public void BoncukAzalttıyoruz()
    {
        if (carpismaVar)
        {
            Debug.Log("boncuk objesini burda destroy edicem");
            Destroy(GameObject.FindGameObjectWithTag("boncuk"));
        }
    }
  
}
