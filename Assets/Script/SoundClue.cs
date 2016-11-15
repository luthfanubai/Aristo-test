using UnityEngine;
using System.Collections;

public class SoundClue : MonoBehaviour {

	bool firstTime = true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (firstTime) {
			if (gameObject == isActiveAndEnabled) {
				AudioSource audio = GetComponent<AudioSource> ();
				audio.Play ();
				firstTime = false;
			}
		}
	}
}
