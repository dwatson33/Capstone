using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //required

public class VarTest0 : MonoBehaviour {

	//initializes button text first
	//will have to place text box into the script once attached
	public Text mytext0 = null;
	public Text mytext1 = null;
	public Text mytext2 = null;

	//used so to toggle back and forth between the button's original text and new
	public int counter = 0;
	public int counterother = 0;

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
	public void change_incorrect0()
	{
		counter++;
		//first
		if (counter % 2 == 1) {
			//calls upont the variable within correctTester and then sets it to the button's text field
			mytext0.text = "Incorrect";
		}
		counter--;
	}
	public void change_incorrect1()
	{
		counter++;
		//first
		if (counter % 2 == 1) {
			//calls upont the variable within correctTester and then sets it to the button's text field
			mytext0.text = "Incorrect";
		}
		counter--;
	}
	public void change()
	{
		counterother++;
		//first
		if (counter % 2 == 1) {
			//calls upont the variable within correctTester and then sets it to the button's text field
			mytext0.text = "Correct";
			//calls upon the disableObject script to disable the object wanted
			enablePath.disabled = true;
		} else {
			mytext0.text = "C. 5";
		}
		counterother--;
	}
}
