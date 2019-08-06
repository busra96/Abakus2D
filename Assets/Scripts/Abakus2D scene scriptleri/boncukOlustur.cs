using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boncukOlustur : MonoBehaviour
{
    public GameObject boncukPrefab;
    private GameObject projectile;

   

    public void BoncukArttir()
    {
        boncukprefabsayi[] Boncuklar = GetComponentsInChildren<boncukprefabsayi>();
        
        //Boncuklar dizisinde oluşan boncuk sayısı dokuzdan küçük ise boncuk olusturabiliriz
        if(Boncuklar.Length < 9){
            projectile = Instantiate(boncukPrefab, transform.position, transform.rotation);
            projectile.transform.SetParent(gameObject.transform);
        }
    }

    
    public void BoncukAzalt()
    {
        boncukprefabsayi[] Boncuklar = GetComponentsInChildren<boncukprefabsayi>();
        foreach(boncukprefabsayi item in Boncuklar)
        {
            if(item.carp == true)
            {
                    Destroy(item.gameObject);
            }


        }
    }


    public void BoncukRefresh()
    {
        boncukprefabsayi[] Boncuklar = GetComponentsInChildren<boncukprefabsayi>();
        foreach (boncukprefabsayi item in Boncuklar)
        {
            if(Boncuklar.Length > 0)
            {
                if (item.refresh == true)
                {
                    for (int i = 0; i < Boncuklar.Length; i++)
                    {
                        Debug.Log(i);
                        Destroy(item.gameObject);
                       
                    }
                }
            }
            

        }

    }

  
    
}
