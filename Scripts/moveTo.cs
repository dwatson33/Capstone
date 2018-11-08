using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTo : MonoBehaviour {

	// creates to public objects
	public GameObject Object1;
	public GameObject Object2;

	// Use this for initialization
	void Start () {
		//not used in this script
	}
	
	// Update is called once per frame
	void Update () {
		//sets the current position of object2 to object1
		Object1.transform.position = Object2.transform.position;
	}
}
