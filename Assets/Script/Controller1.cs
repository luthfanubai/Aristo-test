using UnityEngine;
using System.Collections;

public class Controller1 : MonoBehaviour {
	public GameObject pesanRahasia;
	// Use this for initialization
	void Start () {
		pesanRahasia.SetActive (false);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseUpAsButton() {
		pesanRahasia.SetActive (true);
	}

}
