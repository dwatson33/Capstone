using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thirdTrigger : MonoBehaviour {

	public GameObject uiObject1a;
	public GameObject uiObject1b;
	public GameObject uiObject1c;

	// Use this for initialization
	void Start () {
		uiObject1a.SetActive (false);
		uiObject1b.SetActive (false);
		uiObject1c.SetActive (false);
	}

	void OnTriggerEnter(Collider player)
	{
		if (player.gameObject.tag == "Player") {
			uiObject1a.SetActive (true);
			StartCoroutine ("WaitForSec"); //quarintine
		}

	}

	IEnumerator WaitForSec()
	{
		yield return new WaitForSeconds (5);
		Destroy (uiObject1a);

		uiObject1b.SetActive (true);
		yield return new WaitForSeconds (5);
		Destroy (uiObject1b);

		uiObject1c.SetActive (true);
		yield return new WaitForSeconds (5);
		Destroy (uiObject1c);
		Destroy (gameObject);
	}

	// Update is called once per frame
	void Update () {

	}
}
