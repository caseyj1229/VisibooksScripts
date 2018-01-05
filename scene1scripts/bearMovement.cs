using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bearMovement : MonoBehaviour {

	public GameObject bear;
	Animator anim;
	private Vector3 target = new Vector3 (16.75f,0f,-6f);
	public float speed = 1f;

	void Start(){
		anim = bear.GetComponent<Animator> ();
		anim.Play ("Walking");
	}

	void Update () {
		float step = speed * Time.deltaTime;
		bear.transform.position = Vector3.MoveTowards (bear.transform.position,target,step);
		if (bear.transform.position.Equals (target)) {
			anim.Play ("Idle");
		}
	}
}
