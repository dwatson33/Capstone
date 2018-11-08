using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VarTest0_translate : MonoBehaviour {

	public GameObject objectToDisable; 
	public int a;
	public int b;

	// Use this for initialization
	void Start () {
		//not used in this script
	}
	
	// Update is called once per frame
	void Update () {
		if (b == 1) {
			transform.Translate (a, 0f, 0f);
		}
	}


}
