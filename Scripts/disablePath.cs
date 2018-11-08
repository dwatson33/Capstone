using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disablePath : MonoBehaviour {

	//created game object
	GameObject varGameObject;

	void Awake () {
		//sets varGameObject to the object tagged Player
		varGameObject = GameObject.FindWithTag("Player");
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider player)
	{
		//when the gameobect tagged Player enters this trigger the FollowPath and MovementPath are disabled
		//this is used to give the player control after they finish the tutorial at the start
		if (player.gameObject.tag == "Player") {
			varGameObject.GetComponent<FollowPath>().enabled = false;
			varGameObject.GetComponent<MovementPath>().enabled = false;
		}
	}
}
