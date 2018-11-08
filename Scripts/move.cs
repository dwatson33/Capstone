using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

	//public float varaibles used to set the user's speed
	public float a;
	public float b;

	// Use this for initialization
	void Start () {
		//not used in this script
	}
	
	// Update is called once per frame
	void Update () {
		//sets the W, S, A, D keys to allow the user to traverse the scene
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (a, 0f, 0f);// will depend how the camera is place and kind of the object
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.Translate (-a, 0f, 0f);
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.Translate (0f, 0f, a);
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.Translate (0f, 0f, -a);
		}

		//sets the Z and X keys so that user can rotate themselvesa
		// Rotate
		// same as transform, need float
		if (Input.GetKey (KeyCode.Z)) {
			transform.Rotate (0f, b, 0f); //on the x axis
		}
		if (Input.GetKey (KeyCode.X)) {
			transform.Rotate (0f, -b, 0f); 
		}
		
	}
}
