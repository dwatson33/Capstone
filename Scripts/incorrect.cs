using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //required

public class incorrect : MonoBehaviour {

	//initializes button text first
	//will have to place text box into the script once attached
	public Text mytext = null;
	public Text mytext1 = null;
	public Text mytext2 = null;
	public Text mytext3 = null;

	//used so to toggle back and forth between the button's original text and new
	public int counter = 0;

	void Awake () {
		//not used in this script
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
			mytext.text = "NOPE!";
			//calls upon the disableObject script to disable the object wanted
		} 
		counter--;
	}
	public void change1()
	{
		counter++;
		//first
		if (counter % 2 == 1) {
			//calls upont the variable within correctTester and then sets it to the button's text field
			mytext1.text = "Nah!";
			//calls upon the disableObject script to disable the object wanted
		}
		counter--;
	}
	public void change2()
	{
		counter++;
		//first
		if (counter % 2 == 1) {
			//calls upont the variable within correctTester and then sets it to the button's text field
			mytext2.text = "NO!";
			//calls upon the disableObject script to disable the object wanted
		} 
		counter--;
	}
	public void change3()
	{
		counter++;
		//first
		if (counter % 2 == 1) {
			//calls upont the variable within correctTester and then sets it to the button's text field
			mytext3.text = "Wrong!";
			//calls upon the disableObject script to disable the object wanted
		} 
		counter--;
	}


}
