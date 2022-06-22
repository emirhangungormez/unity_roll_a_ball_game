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
    public Text kazand�nText;

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

    void OnTriggerEnter(Collider other) //bir kere temas oldu�unda �al��acak metod
    {
        if (other.gameObject.tag == "topla")
        {
            other.gameObject.SetActive(false); //objeleri kapat
            sayac++;

            sayacText.text = "Sayac: " + sayac;

            if(sayac == toplanilacakObjeSayisi)
            {
                kazand�nText.text = "Kazand�n!";
            }
        }    
    }

    /* void OnTriggerExit(Collider other) //temastan ��kt��� an �al��acak metod
    {
        
    }

    void OnTriggerStay(Collider other) //temas oldu�u m�ddet�e �al��acak metod
    {
        
    } */
}
