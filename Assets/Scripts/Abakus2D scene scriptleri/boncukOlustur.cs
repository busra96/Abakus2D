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

  
    
}
