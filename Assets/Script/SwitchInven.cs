using UnityEngine;
using System.Collections;

public class SwitchInven : MonoBehaviour {
	public GameObject item1 ;
	public GameObject item2 ;

	public void click (){
		if (item1.activeSelf) {
			item2.SetActive (true);
			item1.SetActive (false);
		}
		else {
			item2.SetActive (false);
			item1.SetActive (true);
		}
	}

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnMouseUpAsButton()
	{
		click ();
	}

}
