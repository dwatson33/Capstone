using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTutorial : MonoBehaviour {

	public float x = 0.1f;
	public float y = 0.1f;
	public float z = 0.1f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		//transform.Translate(0.05f,0f,0f);
		//transform.Translate(0.05f,0f,0f);
		//transform.Translate(0f,0f,0.05f);

		StartCoroutine ("WaitForZ");

		//StartCoroutine ("WaitForY");

	}

	IEnumerator WaitForZ()
	{
		yield return new WaitForSeconds (15);
		moveZ();

	}

	IEnumerator WaitForX()
	{
		yield return new WaitForSeconds (15);
		moveX ();


	}

	IEnumerator WaitForY()
	{
		moveY ();
		yield return new WaitForSeconds (5);

	}


	void moveX(){
		transform.Translate(0.01f,0f,0f);

	}

	void moveY(){
		transform.Translate(0f,0.01f,0f);
	}


	void moveZ(){
		transform.Translate(0f,0f,0.01f);
	}

}
