using UnityEngine;
using System.Collections;

public class Senapan : MonoBehaviour {
	int tap = 0;
	public GameObject kapow;
	public GameObject efekSenapan;
	public GameObject efekMusuh;
	public GameObject inggris;
	public GameObject pedang;
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
		if (tap == 10	) {
			
			StartCoroutine (delayKapow ());

		}
	}

	IEnumerator delayDor()
	{
		efekMusuh.SetActive (true);
		efekSenapan.SetActive (true);
		yield return new WaitForSeconds (0.5f);
		efekMusuh.SetActive (false);
		efekSenapan.SetActive (false);
	}

	IEnumerator delayKapow()
	{
		kapow.SetActive (true);
		inggris.SetActive (false);
		yield return new WaitForSeconds (2);
		kapow.SetActive (false);
		this.gameObject.SetActive (false);
		yield return new WaitForSeconds (1);
		pedang.SetActive (true);

	}
}
