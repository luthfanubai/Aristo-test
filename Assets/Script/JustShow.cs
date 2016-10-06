using UnityEngine;
using System.Collections;

public class JustShow : MonoBehaviour {
	//public GameObject toShow;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void click(GameObject toShow)
	{
		toShow.SetActive (true);	
	}

	void OnMouseUpAsButton()
	{
	}
}
