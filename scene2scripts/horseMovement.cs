using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horseMovement : MonoBehaviour {

	public GameObject horse;
	Animator anim;
	private Vector3 target = new Vector3 (6.5f,0f,13f);
	public float speed = 1f;
	bool idle = false;

	void Start(){
		anim = horse.GetComponent<Animator> ();
		//anim.Play ("Horse_Walking");
	}

	void Update () {
		float step = speed * Time.deltaTime;
		horse.transform.position = Vector3.MoveTowards (horse.transform.position,target,step);
		if (horse.transform.position.Equals (target) && idle == false) {
			playIdle ();
		}
	}

	void playIdle (){
		anim.Play ("Horse_Idle");
		idle = false;
	}
}
