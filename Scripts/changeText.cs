using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Basic Script used to test and build into correct.cs

//script added to main camera, placyer
//assign player/camera to on click and the function is change
public class changeText : MonoBehaviour {

	//initializes button text first
	//will have to place text box into the script once attached
	public Text mytext = null;

	//used so to toggle back and forth between the button's original text and new
	//counter is incremented each time the button is clicked
	public int counter = 0;

	//runs each time the button in clicked
	public void change()
	{
		counter++;
		//appears when the button is clicked
		if (counter % 2 == 1) {
			mytext.text = "Pause";
		} else {
			mytext.text = "Start";
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
