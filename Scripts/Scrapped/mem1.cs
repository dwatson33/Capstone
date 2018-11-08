using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mem1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject text = new GameObject();
		TextMesh t = text.AddComponent<TextMesh>();
		t.text = "1";
		t.fontSize = 30;

		t.transform.localEulerAngles += new Vector3(90, 0, 0);
		t.transform.localPosition += new Vector3(56f, 3f, 40f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
