using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//used to disable or enable object, specific to portal opening
public class disableObject : MonoBehaviour {

	//calls game object and sets it to objectToDisable
	//this object is whatever the user wants
	public GameObject objectToDisable; 
	//disabled variable set to false
	public static bool disabled = false;

	// Use this for initialization
	void Start () {
		//not used in this script
	}
	
	// Update is called once per frame
	void Update () {
		//updates the objectToDisable 
		//when not disabled then the object is not disabled and then else is the disabling
		if (!disabled) {
			objectToDisable.SetActive (true);
		} else {
			objectToDisable.SetActive (false);
		}

		
	}
}
