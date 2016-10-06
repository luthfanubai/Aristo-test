using UnityEngine;
using System.Collections;

public class Toogle : MonoBehaviour {
	public GameObject clue ;

	public void click (){
		if (clue.activeSelf) {
			clue.SetActive (false);
		}
		else {
			clue.SetActive (true);
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
