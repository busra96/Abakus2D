using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class RandomRakamUret : MonoBehaviour
{
    public TextMeshProUGUI BirlerBasamagi;
    public TextMeshProUGUI OnlarBasamagi;
    public TextMeshProUGUI YuzlerBasamagi;
    public TextMeshProUGUI BinlerBasamagi;


    public TextMeshProUGUI RandomBirlerBasamagi;
    public TextMeshProUGUI RandomOnlarBasamagi;
    public TextMeshProUGUI RandomYuzlerBasamagi;
    public TextMeshProUGUI RandomBinlerBasamagi;

    private bool calistir = false;


    void Start()
    {
        StartCoroutine("RandomSayiOlustur");
    }
  


    // Update is called once per frame
    void Update()
    {
        //Random değerlerle abakusteki textboxları kontrol ediyorum
        if(BirlerBasamagi.text == RandomBirlerBasamagi.text && OnlarBasamagi.text == RandomOnlarBasamagi.text && YuzlerBasamagi.text == RandomYuzlerBasamagi.text && BinlerBasamagi.text == RandomBinlerBasamagi.text)
        {
            //Burası doğru kısmı aferin animasyonu calısıcak
            Debug.Log("doğru");
            calistir = true;
           
        }

    }

    IEnumerator RandomSayiOlustur()
    {
        int sayi1 = Random.Range(0, 10);
        RandomBirlerBasamagi.text = sayi1.ToString();

        int sayi2 = Random.Range(0, 10);
        RandomOnlarBasamagi.text = sayi2.ToString();

        int sayi3 = Random.Range(0, 10);
        RandomYuzlerBasamagi.text = sayi3.ToString();

        int sayi4 = Random.Range(0, 10);
        RandomBinlerBasamagi.text = sayi4.ToString();

        yield return null;
    }
}
