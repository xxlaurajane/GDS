using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp: MonoBehaviour {
	public GameObject heldPickAxe;

		void OnTriggerEnter(Collider other) 
     {
         if (other.gameObject.CompareTag ("Pick Up"))
         {
             other.gameObject.SetActive (false);
			 heldPickAxe.SetActive(true);
			 
         }
		 }
		 
		 }