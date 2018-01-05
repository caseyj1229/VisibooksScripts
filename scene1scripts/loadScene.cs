using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour {

	private bool isLookedAt = false;
	private Text displayText;
	public float countdown3 = 2.0f;
	public float countdown2 = 3.0f;
	public float countdown1 = 4.0f;
	public float timeDurationFinal = 5.0f;
	private float lookTime = 0.0f;

	void Start(){
		displayText = GameObject.Find ("Text2").GetComponent<Text>();
	}

	void Update () {

		if (isLookedAt) {
			lookTime = lookTime + Time.deltaTime;
			//Debug.Log (lookTime);
		}

		if (lookTime > countdown3 && lookTime < countdown2) {
			displayText.text = "Next Scene in: 3";
		}


		if (lookTime > countdown2 && lookTime < countdown1) {
			displayText.text = "Next Scene in: 2";
		}


		if (lookTime > countdown1 && lookTime < timeDurationFinal) {
			displayText.text = "Next Scene in: 1";
		}


		if (lookTime > timeDurationFinal) {
			lookTime = 0f;
			displayText.text = "Loading Next Scene...";
			SceneManager.LoadScene ("Forest2");
		}

		if (!isLookedAt) {
			lookTime = 0;
			displayText.text = "Look Here to Load the Next Scene";
		}
	}

	public void SetGazedAt(bool gazedAt) {
		isLookedAt = gazedAt;
	}
}
