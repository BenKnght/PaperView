using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BallSpawner : MonoBehaviour {

	public GameObject ping;
	public GameObject cannon;
	public string ballType = "ping";
	public float shootForce = 100.0f;
	public string state = "looking";
	public int shotClock = 0;
	public bool up = true;
	public int score = 0;
	public Text scoreText;
	public Text uiText;

	private float shootMax = 2200.0f;
	private float shootMin = 100.0f;
	private float shootInt = 30.0f;
	private GameObject instance;

	private int maxClock = 160;

	// Use this for initialization
	void Start () {
		scoreText.text = "Score: " + score;
		uiText.text = "Ready" + "\nBall: " + ballType;
	}

	public void ToCannon() {
		ballType = "cannon";
	}

	public void ToPing() {
		ballType = "ping";
	}

	public void switchBall () {
		if (ballType == "ping") {
			ballType = "cannon";
		} else {
			ballType = "ping";
		}
	}

	public void QuitGame() {
		Application.Quit ();
	}

	// Update is called once per frame
	void Update () {

		if (state == "looking") {
			uiText.text = "Ready" + "\nBall: " + ballType;
		} else if (state == "charging") {
			uiText.text = "Power: " + ((int)(shootForce/100)) + "\nBall: " + ballType;
		} else {
			uiText.text = "Shot!" + "\nBall: " + ballType;
		}

		scoreText.text = "Score: " + score;

		if (state == "charging") {

			// Move shootForce up and down bet
			if (up) {
				if (shootForce < shootMax) {
					shootForce = shootForce + shootInt;
				} else {
					up = false;
				}
			} else {
				if (shootForce > shootMin) {
					shootForce = shootForce - shootInt;
				} else {
					up = true;
				}
			}

		} else if (state == "shot") {
			if (shotClock < maxClock) {
				shotClock = shotClock + 1;
			} else {
				Lose ();
			}
		}

		if (Input.GetButtonDown("Fire1")) {
			
			if (state == "looking") {
				
				state = "charging";
				shootForce = shootMin;
				up = true;

			} else if (state == "charging") {

				state = "shot";
				shotClock = 0;

				if (ballType == "ping") {
					instance = (GameObject)Instantiate (ping, transform.position, transform.rotation);
					instance.GetComponent<Rigidbody> ().AddForce (instance.transform.forward * shootForce);
				} else if (ballType == "cannon") {
					instance = (GameObject)Instantiate (cannon, transform.position, transform.rotation);
					instance.GetComponent<Rigidbody> ().AddForce (instance.transform.forward * shootForce);
				} else {
					// DO NOTHING
				}
	
			}

		}

	}

	public void Win() {
		score = score + 1;
		state = "looking";
		if (ballType == "ping") {
			Destroy (instance);
		} else if (ballType == "cannon") {
			Destroy (instance);
		} else {
			// DO NOTHING
		}
	}

	public void Lose() {
		score = 0;
		state = "looking";
		if (ballType == "ping") {
			Destroy (instance);
		} else if (ballType == "cannon") {
			Destroy (instance);
		} else {
			// DO NOTHING
		}
	}

	public void backToMain () {
		SceneManager.LoadScene ("MainMenu");
	}

}
