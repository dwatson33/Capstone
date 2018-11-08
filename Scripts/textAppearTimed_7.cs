using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textAppearTimed_7 : MonoBehaviour {

	//creates multiple gameobjects uiobject
	public GameObject uiObject0;
	public GameObject uiObject1;
	public GameObject uiObject2;
	public GameObject uiObject3;
	public GameObject uiObject4;
	public GameObject uiObject5;
	public GameObject uiObject6;

	//created the int for the amount of time you want it to take to appear
	public int time;

	// Use this for initialization
	void Start () {
		//sets these objects to false at the start, hiding them
		uiObject0.SetActive (false);
		uiObject1.SetActive (false);
		uiObject2.SetActive (false);
		uiObject3.SetActive (false);
		uiObject4.SetActive (false);
		uiObject5.SetActive (false);
		uiObject6.SetActive (false);
	}

	// Update is called once per frame
	void Update () {
		//not used in this script
	}

	// Use this for initialization
	void OnTriggerEnter(Collider player)
	{
		if (player.gameObject.tag == "Player") {
			uiObject0.SetActive (true);
			StartCoroutine ("WaitForSec"); //quarintine
		}

	}

	IEnumerator WaitForSec()
	{
		yield return new WaitForSeconds (time);
		uiObject0.SetActive (false);

		uiObject1.SetActive (true);
		yield return new WaitForSeconds (time);

		uiObject2.SetActive (true);
		yield return new WaitForSeconds (time);

		uiObject3.SetActive (true);
		yield return new WaitForSeconds (time);

		uiObject4.SetActive (true);
		yield return new WaitForSeconds (time);

		uiObject5.SetActive (true);
		yield return new WaitForSeconds (time);

		uiObject6.SetActive (true);
		yield return new WaitForSeconds (time);

	}

}
