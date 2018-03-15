using UnityEngine;
using System.Collections;

public class Ballin : MonoBehaviour {

	public ChangePlace canRef;
	public BallSpawner proj;
	public int score = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider coll) {
		if (coll.tag == "ball") {
			score = score + 1;
			proj.Win ();
			canRef.MovePos ();
		}
	}
}
