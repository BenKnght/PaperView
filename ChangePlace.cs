using UnityEngine;
using System.Collections;

public class ChangePlace : MonoBehaviour {

	// These are possible positions for the can
	// 20 available values
	float[] canPosX = {1.3f, 2.2f, 0.4f, 3.149f, 0.75f, -0.48f, 1.11f, 3.74f, -0.52f, -0.92f, -0.58f, -0.89f, 0.71f, 2.086f, 2.954f, 3.71f, 3.149f, 3.149f, 0.71f, 0.71f};
	float[] canPosY = {0.653f, 0.653f, 0.653f, 1.248f, 0.051f, 0.431f, 0.051f, 0.051f, 0.051f, 0.653f, 0.653f, 0.653f, 1.245f, 0.051f, 0.051f, 0.051f, 1.248f, 1.248f, 1.245f, 1.245f};
	float[] canPosZ = {0.7f, 0.7f, 0.7f, 0.956f, -0.37f, 0.226f, -2.31f, 0.96f, -0.45f, -1.452f, -2.11f, -2.66f, -3.36f, -0.501f, -1.426f, -3.457f, 0.956f, 0.956f, -3.36f, -3.36f};

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void MovePos() {
		int index = Mathf.RoundToInt(Random.value * 19);
		transform.position = new Vector3(5.0f*canPosX[index], 8.0f*canPosY[index], 5.0f*canPosZ[index]);
	}
}
