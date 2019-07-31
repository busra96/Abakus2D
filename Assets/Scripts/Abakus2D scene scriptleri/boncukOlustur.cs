using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boncukOlustur : MonoBehaviour
{
    public GameObject boncukPrefab;
    private GameObject projectile;

    private boncukprefabsayi boncuksil;

    void Start()
    {
        boncuksil = GetComponent<boncukprefabsayi>();
    }

    public void BoncukArttir()
    {
        projectile = Instantiate(boncukPrefab,transform.position,transform.rotation);
        projectile.transform.SetParent(gameObject.transform);

    }

    public void BoncukAzalt()
    {
        boncukprefabsayi[] Boncuklar = GetComponentsInChildren<boncukprefabsayi>();
        foreach(boncukprefabsayi item in Boncuklar)
        {
        if(item.carp == true)
        {
                Destroy(item.gameObject);

                Debug.Log("doğru yere eriştik");
        }
        }


       

    }

  
    
}
