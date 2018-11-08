using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textPath : MonoBehaviour {

	public GameObject uiObject1;

	// Use this for initialization
	void Start () {
		uiObject1.SetActive (false);
	}

	void OnTriggerEnter(Collider player)
	{
		if (player.gameObject.tag == "Player") {
			uiObject1.SetActive (true);
		}

	}

	void OnTriggerExit(Collider player)
	{
		if (player.gameObject.tag == "Player") {
			uiObject1.SetActive (false);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
