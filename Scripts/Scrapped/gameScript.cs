using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameScript : MonoBehaviour {

	//uiObject is the text
	public GameObject uiObject;
	// Use this for initialization
	void Start () {
		uiObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider player)
	{
		if (player.gameObject.tag == "Player") {
			uiObject.SetActive (true);
			// doesn't have to start a function
			StartCoroutine ("WaitForSec"); //quarintine
		}
	}
	// have to start using quiarintine
	IEnumerator WaitForSec()
	{
		yield return new WaitForSeconds (5);
		//Destroy (uiObject);
		//Destroy (gameObject);
	}
}
