using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainFlow: MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void toHowTo () {
		SceneManager.LoadScene ("HowTo");
	}

	public void quitGame () {
		Application.Quit ();
	}

	public void toGame () {
		SceneManager.LoadScene ("OfficePV");
	}

}
