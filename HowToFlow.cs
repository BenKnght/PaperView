using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HowToFlow : MonoBehaviour {

	public TextMesh instructions;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void backToMain () {
		SceneManager.LoadScene ("MainMenu");
	}

	public void instShooting () {
		instructions.text = 
			"Try to get the ball into\n" +
			"the can. Press the trigger once\n" +
			"to charge and again to fire!";
	}

	public void instScores () {
		instructions.text = 
			"Every time you get the ball\n" +
			"into the can, you get a point.\n" +
			"If you miss, you go back to 0.";

	}

	public void instComputer () {
		instructions.text = 
			"The computer beside you will\n" +
			"display your score and options.\n" +
			"Use it to switch balls and exit.";
	}

	public void instTips () {
		instructions.text = 
			"Sometimes the can stays in the\n" +
			"same place if you make a shot.\n" +
			"Look at your score to see if you hit.";

	}

}
