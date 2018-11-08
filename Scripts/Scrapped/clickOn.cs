using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickOn : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseOver()
	{
		GetComponent<Transform> ().localScale = new Vector3 (1.2f, 1.2f, 1);
		GetComponent<TextMesh> ().color = new Color (0, 1, 0, 1);
	}

	void OnMouseExit()
	{
		GetComponent<Transform> ().localScale = new Vector3 (1, 1, 1);
		GetComponent<TextMesh> ().color = new Color (1, 1, 1, 1);
	}

	void OnMouseDown()
	{
		GetComponent<TextMesh> ().text = "Replace";
	}


}
