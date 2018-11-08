using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatBoxFunction : MonoBehaviour {
	//manipulate field
	[SerializeField] ContentSizeFitter contentSizeFilter;
	[SerializeField] Text showHideButtonText;

	bool isChatShowing = false;

	//public string myAnswer;
	//public string Outcome;

	public void ToggleChat (){
		isChatShowing = !isChatShowing;
		if(isChatShowing){
			contentSizeFilter.verticalFit = ContentSizeFitter.FitMode.PreferredSize;
			showHideButtonText.text = "Answer";
		}
		else { 
			contentSizeFilter.verticalFit = ContentSizeFitter.FitMode.MinSize;
			//if the chat isn't showing say showchat
			showHideButtonText.text = "Right/Wrong";

		}

	}










	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
