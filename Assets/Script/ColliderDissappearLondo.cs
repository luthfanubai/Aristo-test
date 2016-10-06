using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Reflection;
//using iTween;


//namespace collider{


public class ColliderDissappearLondo : MonoBehaviour {

	public GameObject willBeSHOWN;
	public GameObject willBeSHOWN2;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
			
	}

	void OnCollisionEnter (Collision col)
	{
	//	if (col.gameObject.name == "3BambuRuncing") {
	//			//iTween.FadeTo (col.gameObject, iTween.Hash("alpha",0,"time",1));
		StartCoroutine(delay(col));
				
		
	}

	IEnumerator delay(Collision col)
	{
		//yield return new WaitForSeconds (1);
		//Console.Write ("destroy");
		Destroy (col.gameObject);
		willBeSHOWN.SetActive (true);

		yield return new WaitForSeconds (1);
		//Destroy (this.gameObject);


		willBeSHOWN2.SetActive (true);
		willBeSHOWN.SetActive (false);


	}



	}
//}