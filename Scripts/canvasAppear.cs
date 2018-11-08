using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canvasAppear : MonoBehaviour {

	//takes a canvas as input
	public Canvas myCanvas; //Your target for the refference

	void Start () {
		myCanvas.enabled = false;
	}
	//displays the inputted canvas to the object labeled Player
	void OnTriggerEnter(Collider player){
		if (player.tag =="Player"){
			myCanvas.enabled = true;
		}
	}

	// Update is called once per frame
	void Update () {
		//not used in this script
	}

}
