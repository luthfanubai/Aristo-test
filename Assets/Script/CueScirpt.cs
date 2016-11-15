using UnityEngine;
using System.Collections;

public class CueScirpt : MonoBehaviour {
	Animator backforth;

	// Use this for initialization
	void Start () {
		backforth = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKey) {
			if (backforth.bodyPosition.x > -0.03f && backforth.bodyPosition.x < 0.03f) {
				Debug.Break ();
			}
		}		
	}
}
