using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textAppear_3 : MonoBehaviour {

	//creates multiple gameobjects uiobject
	public GameObject uiObject0;
	public GameObject uiObject1;
	public GameObject uiObject2;

	// Use this for initialization
	void Start () {
		//sets these objects to false at the start, hiding them
		uiObject0.SetActive (false);
		uiObject1.SetActive (false);
		uiObject2.SetActive (false);
	}

	// Update is called once per frame
	void Update () {
		//not used in this script
	}

	void OnTriggerEnter(Collider player)
	{
		//if the gameobject tagged player enters the trigger the objects are set to true, showing them
		if (player.gameObject.tag == "Player") {
			uiObject0.SetActive (true);
		}
		if (player.gameObject.tag == "Player") {
			uiObject1.SetActive (true);
		}
		if (player.gameObject.tag == "Player") {
			uiObject2.SetActive (true);
		}
	}
}
