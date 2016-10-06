using UnityEngine;
using System.Collections;

public class ButtonController : MonoBehaviour {

	public GameObject toShow;
	public GameObject toHide; 
	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void Update () {

	}

	void OnMouseUpAsButton(){
		toShow.SetActive (true);
		toHide.SetActive (false);
	}
}