using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UI_Control : MonoBehaviour
{
	public string MyText;
	public GameObject Kp_Display;

	private Text text;

	public void MyFunction (string MyCount)
	{
		Text text = Kp_Display.GetComponent<Text> ();
		if (MyCount == "X")
		{
			MyText="";
			MyCount="";
		}

		MyText += MyCount;
		text.text = MyText;
	}
}

