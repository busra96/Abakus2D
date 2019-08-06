using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boncukprefabsayi : MonoBehaviour
{
    public int sayi;
    public bool carp = false;
    public bool refresh = false;

    void OnTriggerEnter2D(Collider2D dcarp)
    {
        if(dcarp.gameObject.tag == "delete")
        {
            carp = true;
        }
    }

    void OnTriggerStay2D(Collider2D drefreshet)
    {
        if(drefreshet.gameObject.tag == "refreshEt")
        {
            refresh = true;
        }
    }

}
