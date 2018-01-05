using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controllerScript : MonoBehaviour {
    public Transform canvas;

	
	public void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		Ray ray = Camera.main.ViewportPointToRay (new Vector3 (0.5f, 0.5f, 0));
		RaycastHit hit;

		if(Physics.Raycast (ray, out hit)){
			if (hit.collider.name.Contains("ForestFloor")){
                canvas.gameObject.SetActive(true);
                Time.timeScale = 0;
            }
			else{
                canvas.gameObject.SetActive(false);
                Time.timeScale = 1;

			}
		}
	}
}
