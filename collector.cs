using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collector: MonoBehaviour {
	public GameObject platformcrystalred;
	public GameObject platformcrystalblue;
	public GameObject platformcrystalgreen;
	public GameObject crystalgroupred;
	public GameObject crystalgroupblue;
	public GameObject crystalgroupgreen;
	
	

	void OnTriggerEnter(Collider other) 
    {
		
		if (other.gameObject == crystalgroupblue)
		{
			platformcrystalblue.SetActive(true);
			AudioSource audio = GetComponent<AudioSource>();
			audio.Play();
		}
		if (other.gameObject == crystalgroupred)
		{
			platformcrystalred.SetActive(true);
			AudioSource audio = GetComponent<AudioSource>();
			audio.Play();
		}
		if (other.gameObject == crystalgroupgreen)
		{
			platformcrystalgreen.SetActive(true);
			AudioSource audio = GetComponent<AudioSource>();
			audio.Play();
		}
	
	}	 
}