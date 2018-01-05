using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class teleportToSpawn : MonoBehaviour {

	private Vector3 endPoint = new Vector3(0f,1.0f,-4.5f);
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
