using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textDisappear : MonoBehaviour {

	//creates the gameobject uiobject
	public GameObject uiObject;

	// Use this for initialization
	void Start () {
		//not used in this script
	}

	// Update is called once per frame
	void Update () {
		//not used in this script
	}

	void OnTriggerEnter(Collider player)
	{
		//if the gameobject tagged player enters the trigger the object is set to false, hiding it
		if (player.gameObject.tag == "Player") {
			uiObject.SetActive (false);
		}

	}
	
}
