using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour {

	//public varaible a allows the user to input a rotation varaible
	public int a;

	// Use this for initialization
	void Start () {
		//not used in this script
	}

	// Update is called once per frame
	void Update () {
		//not used in this script
	}

	void OnTriggerEnter(Collider otherCollider)
	{
		//when a collision occurs with the objec that has this script and the object is labeled 
		//RotationTriggerLeft, then it'll rotate the object with this script
		if (otherCollider.tag == "RotationTriggerLeft") {
			transform.Rotate(0,a,0);
		}
		//the same occurs here, just the opposite direction and a label of RotationTriggerRight
		if (otherCollider.tag == "RotationTriggerRight") {
			transform.Rotate(0,-a,0);
		}
	}
}
