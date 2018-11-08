using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textDisappear_5 : MonoBehaviour {

	//creates the gameobjects 
	public GameObject uiObject0;
	public GameObject uiObject1;
	public GameObject uiObject2;
	public GameObject uiObject3;
	public GameObject uiObject4;

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
		//if the gameobject tagged player enters the trigger the objects are set to false, hiding them
		if (player.gameObject.tag == "Player") {
			uiObject0.SetActive (false);
		}
		if (player.gameObject.tag == "Player") {
			uiObject1.SetActive (false);
		}
		if (player.gameObject.tag == "Player") {
			uiObject2.SetActive (false);
		}
		if (player.gameObject.tag == "Player") {
			uiObject3.SetActive (false);
		}
		if (player.gameObject.tag == "Player") {
			uiObject4.SetActive (false);
		}


	}

}
