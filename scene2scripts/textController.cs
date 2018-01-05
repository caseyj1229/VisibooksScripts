using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textController : MonoBehaviour {

	private Text text1;
	private bool isLookedAt = false;
	public float timeDuration = 3.0f;
	private float lookTime = 0.0f;
	//	private GameObject gazeTimer;

	void Start () {
		text1 = GameObject.Find("Text").GetComponent<Text> ();
	}

	void Update () {

		if (isLookedAt) {
			lookTime = lookTime + Time.deltaTime;
		}

		if (lookTime > timeDuration) {
			lookTime = 0f;
			text1.text = "I see a Yellow Duck looking at me";
		}

		if (!isLookedAt) {
			lookTime = 0;
		}
	}

	public void SetGazedAt(bool gazedAt) {
		isLookedAt = gazedAt;
	}
}
