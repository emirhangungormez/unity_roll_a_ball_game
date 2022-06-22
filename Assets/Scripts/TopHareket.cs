using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopHareket : MonoBehaviour
{
    Rigidbody fizik;
    public int hiz = 5;
    int sayac = 0;
    public int toplanilacakObjeSayisi;
    public Text sayacText;
    public Text kazandýnText;

    void Start()
    {
        fizik = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
        float yatay = Input.GetAxisRaw("Horizontal");
        float dikey = Input.GetAxisRaw("Vertical");

        Vector3 vec = new Vector3(yatay, 0, dikey);
        fizik.AddForce(vec * hiz);
    }

    void OnTriggerEnter(Collider other) //bir kere temas olduðunda çalýþacak metod
    {
        if (other.gameObject.tag == "topla")
        {
            other.gameObject.SetActive(false); //objeleri kapat
            sayac++;

            sayacText.text = "Sayac: " + sayac;

            if(sayac == toplanilacakObjeSayisi)
            {
                kazandýnText.text = "Kazandýn!";
            }
        }    
    }

    /* void OnTriggerExit(Collider other) //temastan çýktýðý an çalýþacak metod
    {
        
    }

    void OnTriggerStay(Collider other) //temas olduðu müddetçe çalýþacak metod
    {
        
    } */
}
