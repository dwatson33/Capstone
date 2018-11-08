using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePortal : MonoBehaviour {

	public GameObject portalBlock;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider player)
	{
		if (player.gameObject.tag == "Player") {
			portalBlock.SetActive (true);
			// doesn't have to start a function
			StartCoroutine ("WaitForSec"); //quarintine
		}
	}
}
