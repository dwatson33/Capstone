using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enablePath : MonoBehaviour {

	//created game object
	GameObject varGameObject;
	public static bool disabled = false;

	void Awake () {
		//not used in this script
	}

	// Use this for initialization
	void Start () {
		varGameObject.GetComponent<FollowPath>().enabled = false;
		varGameObject.GetComponent<MovementPath>().enabled = false;
	}

	// Update is called once per frame
	void Update () {
		//not used in this script
	}

	void OnTriggerEnter(Collider player)
	{
		//when the gameobect tagged Player enters this trigger the FollowPath and MovementPath are disabled
		//this is used to give the player control after they finish the tutorial at the start
		if (!disabled) {
			varGameObject.GetComponent<FollowPath>().enabled = true;
			varGameObject.GetComponent<MovementPath>().enabled = true;
		}
	}
}
