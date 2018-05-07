using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swing: MonoBehaviour {
 
 
 
 
	protected Animation Animation;
 
     protected void Awake()
     {
         Animation = GetComponent<Animation>();
     }
 
     protected void Update()
     {
         if (Input.GetMouseButtonDown(0))
         {
             Animation.Play(); 			 
         }
         
     }
}