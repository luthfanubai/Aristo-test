using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour {

	//public GameObject loading;

	// Use this for initialization
	void Start () {
		//loading.SetActive (false);	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void onClick()
	{
		//loading.SetActive (true);
		//Application.LoadLevel (id);
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
	}
		
	public void goToMainMenu()
	{
		SceneManager.LoadScene (sceneBuildIndex: 0);
	}

	public void PlaySound()
	{
		AudioSource audio = GetComponent<AudioSource>();
		audio.Play();
	}
}
