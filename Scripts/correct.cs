using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //required

//script added to main camera, placyer
//assign player/camera to on click and the function is change
public class correct : MonoBehaviour {

	//initializes button text first
	//will have to place text box into the script once attached
	public Text mytext = null;
	//used so to toggle back and forth between the button's original text and new
	public int counter = 0;
	
	//used to call upon this script, so we can affect (use) the varaibles within it
	private correctTester ct;

	void Awake () {
		//initialize varaibles
		//used to take type, type is correctTester
		ct = GetComponent<correctTester>();
	}

	// Use this for initialization
	void Start () {
		//not used in this script
	}

	// Update is called once per frame
	void Update () {
		//not used in this script
	}

	//runs each time the button is clicked
	public void change()
	{
		counter++;
		//first
		if (counter % 2 == 1) {
			//calls upont the variable within correctTester and then sets it to the button's text field
			mytext.text = correctTester.t;
			//calls upon the disableObject script to disable the object wanted
			disableObject.disabled = true;
		} else {
			mytext.text = correctTester.s;
			//calls upon the disableObject to re-enable object
			disableObject.disabled = false;
		}
	}
}
