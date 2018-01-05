using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class teleport1 : MonoBehaviour {
	
	private Vector3 endPoint = new Vector3(-11.5f,1.0f,-6.25f);
	private bool isLookedAt = false;
	public float timeDuration = 3.0f;
	private float lookTime = 0.0f;
	public GameObject player1;

	void Update () {

		if (isLookedAt) {
			lookTime = lookTime + Time.deltaTime;
		}

		if (lookTime > timeDuration) {
			lookTime = 0f;
			player1.transform.position = endPoint;
		}

		if (!isLookedAt) {
			lookTime = 0;
		}
	}

	public void SetGazedAt(bool gazedAt) {
		isLookedAt = gazedAt;
	}
}
