using UnityEngine;
using System.Collections;

public class SenapanJPN : MonoBehaviour {
	int tap = 0;
	public GameObject clue;
	public GameObject efekSenapan;
	public GameObject efekMusuh;
	public GameObject gun;
	public GameObject pergike;
	public GameObject slider;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnMouseUpAsButton()
	{
		StartCoroutine (delayDor ());
		tap++;

		if (tap == 5	) {

			StartCoroutine (delayKapow ());

		}
	}

	IEnumerator delayDor()
	{
		efekMusuh.SetActive (true);
		efekSenapan.SetActive (true);
		AudioSource audio = GetComponent<AudioSource>();
		audio.Play ();
		yield return new WaitForSeconds (0.5f);
		efekMusuh.SetActive (false);
		efekSenapan.SetActive (false);

	}

	IEnumerator delayKapow()
	{
		clue.SetActive (true);
		gun.SetActive(false);
		slider.SetActive (false);
		efekMusuh.SetActive (false);
		pergike.SetActive (true);

		yield break;

	}
}
