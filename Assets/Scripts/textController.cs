using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class textController : MonoBehaviour
{
    // public TextMeshProUGUI KalanboncukSayisi, GelenBoncukSayisi, SayiBoncukSayisi;
   // public TextMeshProUGUI SayiBoncukSayisi;

    public TextMeshProUGUI onlarBoncukSayisi;

    private int gelen = 0;
    private int sayi = 0;
    private BoxCollider2D collider;
    private Rigidbody2D rb;



    // Start is called before the first frame update
    void Start()
    {
      //  SayiBoncukSayisi.text = sayi.ToString();
        onlarBoncukSayisi.text = sayi.ToString();
        collider = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
      //  SayiBoncukSayisi.text = sayi.ToString();
        onlarBoncukSayisi.text = sayi.ToString();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "boncuk")
        {
            sayi += 1;

            Debug.Log(sayi);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "boncuk")
        {
            sayi -= 1;

            Debug.Log(sayi);
        }

    }
}
