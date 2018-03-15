using UnityEngine;
using System.Collections;

public class Killer : MonoBehaviour {

	public BallSpawner link;

	// Use this for initialization
	void Start () {
	
	}

	void FixedUpdate () {
		if (link.shotClock >= 200) {
			link.state = "looking";
			link.shotClock = 0;
			Destroy (gameObject);
		}
	}
}
