using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boncukprefabsayi : MonoBehaviour
{
    public int sayi;
    public bool carp = false;

    void OnTriggerEnter2D(Collider2D dcarp)
    {
        if(dcarp.gameObject.tag == "delete")
        {
            carp = true;
        }
    }

}
