using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textAppear : MonoBehaviour {

	//creates the gameobject uiobject
	public GameObject uiObject;

	// Use this for initialization
	void Start () {
		//sets this object to false at the start, hiding it
		uiObject.SetActive (false);
	}

	// Update is called once per frame
	void Update () {
		//not used in this script
	}

	void OnTriggerEnter(Collider player)
	{
		//if the gameobject tagged player enters the trigger the object is set to true, showing it
		if (player.gameObject.tag == "Player") {
			uiObject.SetActive (true);
		}
	}

}
