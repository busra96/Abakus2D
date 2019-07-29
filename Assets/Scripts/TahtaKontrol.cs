using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TahtaKontrol : MonoBehaviour
{
    public List<Transform> Boncuklar = new List<Transform>();

    // Start is called before the first frame update
    void Start()
    {
        Boncuklar = gameObject.GetComponentsInChildren<Transform>().ToList();
        foreach(Transform item in Boncuklar.ToList())
        {
            if(item.tag != "boncuk")
            {
                Boncuklar.Remove(item);
            }
            else
            {
                item.gameObject.SetActive(false);
            }
        }
    }

    public void BoncukArttir()
    {
        foreach (Transform item in Boncuklar.ToList())
        {
        if(item.gameObject.activeSelf == false)
            {
                item.gameObject.SetActive(true);
                break;
            }
        }
    }

    public void BoncukAzalt()
    {
        foreach (Transform item in Boncuklar.ToList())
        {
            if (item.gameObject.activeSelf == true)
            {
                item.gameObject.SetActive(false);
                break;
            }
        }
    }
    // Update is called once per frame

}
