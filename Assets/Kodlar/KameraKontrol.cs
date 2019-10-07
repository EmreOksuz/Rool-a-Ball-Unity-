using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraKontrol : MonoBehaviour {
    public GameObject top;
    Vector3 fark;
	void Start () {

        fark = transform.position - top.transform.position;
	}
	
	void LateUpdate () {
        transform.position = top.transform.position + fark;


	}
}
