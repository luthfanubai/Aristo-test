using UnityEngine;
using System.Collections;

public class Controller2 : MonoBehaviour {
	public GameObject pesanRahasia;
	public GameObject soepardjo;
	// Use this for initialization
	void Start () {
		pesanRahasia.SetActive (false);
		soepardjo.SetActive (false);
	}

	// Update is called once per frame
	void Update () {
		pesanRahasia.SetActive (true);
		soepardjo.SetActive (true);
	}

	void OnMouseUpAsButton() {

	}

}
