using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopKontrol : MonoBehaviour {
    Rigidbody fizik;
    public Text sayacTxt;
    public Text OBTxt;
    public int sayac = 0;
    public int a ;

    void Start () {
        fizik = GetComponent<Rigidbody>();



	}
	
	void FixedUpdate () {

        float yatay = Input.GetAxisRaw("Horizontal");
        float dikey = Input.GetAxisRaw("Vertical");
        Vector3 vec = new Vector3(yatay, 0, dikey);
        fizik.AddForce(vec*15);
        

    }
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Engel")
        {

            Destroy(other.gameObject);
            sayac++;
            sayacTxt.text = "Puan = " + sayac;

            if (sayac == a)
            {
                OBTxt.text = "OYUN BİTTİ";

            }
        }
        


        
    }



}
