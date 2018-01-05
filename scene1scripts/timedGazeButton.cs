using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timedGazeButton : MonoBehaviour {

	private Text text1;
	private bool isLookedAt = false;
	public float timeDuration = 3.0f;
	public float instructionTime = 5.5f;
	private float lookTime = 0.0f;
	private bool changed1 = false;
//	private GameObject gazeTimer;

	void Start () {
		text1 = GameObject.Find("Text").GetComponent<Text> ();
	}

	void Update () {

		if (isLookedAt) {
			lookTime = lookTime + Time.deltaTime;
		}

		if (lookTime > timeDuration && changed1 == false) {
			//lookTime = 0f;
			changed1 = true;
			text1.text = "I see a Blue Horse looking at me";
		}

		if (lookTime > instructionTime) {
			lookTime = 3.1f;
			text1.text = "Look at Yellow Trees to Teleport Forward and Orange Trees to go back";
		}

		if (!isLookedAt) {
			lookTime = 0;
		}
	}

	public void SetGazedAt(bool gazedAt) {
		isLookedAt = gazedAt;
	}
}
