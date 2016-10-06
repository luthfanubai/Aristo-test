using UnityEngine;
using System.Collections;

public class JustHide : MonoBehaviour {
	public GameObject toHide;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseUpAsButton() {
		toHide.SetActive (false);
	}
}
