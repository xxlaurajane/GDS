using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode: MonoBehaviour {
	public GameObject explosion;
	public GameObject debris;
	

	void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag ("Explode"))
        {
            other.gameObject.SetActive (false);	
			explosion.SetActive(true);
			debris.SetActive(true);
        }
	}	 
}