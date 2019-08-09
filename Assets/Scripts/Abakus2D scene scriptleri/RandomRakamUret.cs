using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class RandomRakamUret : MonoBehaviour
{
    //boncukların üzerinde ki textboxlar
    public TextMeshProUGUI BirlerBasamagi;
    public TextMeshProUGUI OnlarBasamagi;
    public TextMeshProUGUI YuzlerBasamagi;
    public TextMeshProUGUI BinlerBasamagi;

    //Random değer üretilen textboxlar
    public TextMeshProUGUI RandomBirlerBasamagi;
    public TextMeshProUGUI RandomOnlarBasamagi;
    public TextMeshProUGUI RandomYuzlerBasamagi;
    public TextMeshProUGUI RandomBinlerBasamagi;

    Animator anim;
    GameObject[] boncukYerleri;
    public bool dogru = false;
    public bool random = false;
  
    void Start()
    {
        anim = GetComponent<Animator>();
        StartCoroutine("RandomSayiOlustur");
        boncukYerleri =  GameObject.FindGameObjectsWithTag("boncukYeri");
    }

    
    //dogru animasyonunun calısmasını sağlayan fonksiyon
    IEnumerator DogruBildi()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        anim.SetTrigger("bildi1");
    }

    IEnumerator YanlisBildi()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        anim.SetTrigger("yanlisOldu");
    }

   //yenile butonuna basılınca ya da cocuk doğru bildikten sonra bu komut calıscak
   public void Refresh()
    {
        anim.SetTrigger("bitti1");
        anim.SetTrigger("yanlisBitti");
        foreach(GameObject item in boncukYerleri)
        {
            item.GetComponent<boncukOlustur>().BoncukRefresh();
        }
        StartCoroutine("RandomSayiOlustur");

    }


    public void KontrolEt()
    {
        //Random değerlerle abakusteki textboxları kontrol ediyorum
        if (BirlerBasamagi.text == RandomBirlerBasamagi.text && OnlarBasamagi.text == RandomOnlarBasamagi.text && YuzlerBasamagi.text == RandomYuzlerBasamagi.text && BinlerBasamagi.text == RandomBinlerBasamagi.text)
        {
            //Burası doğru kısmı aferin animasyonu calısıcak
            dogru = true;
            StartCoroutine("DogruBildi");
        }

        else if (BirlerBasamagi.text != RandomBirlerBasamagi.text || OnlarBasamagi.text != RandomOnlarBasamagi.text || YuzlerBasamagi.text != RandomYuzlerBasamagi.text || BinlerBasamagi.text != RandomBinlerBasamagi.text)
        {
            dogru = false;
            StartCoroutine("YanlisBildi");
        }

    }

    //sayımızı random ürettiğimiz yer
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
