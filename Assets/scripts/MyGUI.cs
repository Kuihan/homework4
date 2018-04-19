using System;
using UnityEngine;
using System.Collections;

public class MyGUI : MonoBehaviour {
	//state
	public static int game = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//edit UI
	void OnGUI()  
	{

		var buttonWidth = 100;  
		var buttonHeight = 50;  

		var buttonX = (Screen.width - buttonWidth) / 2.0f;  
		var buttonY = (Screen.height - buttonHeight) / 2.0f;  
		GUI.Box(new Rect (buttonX * 0.1f, buttonY * 0.1f, buttonWidth, buttonHeight), "Your score:" + ScoreRecoder.total);
		//make a button on center 
		if (game == 0) {
			if (GUI.Button (new Rect (buttonX, buttonY, buttonWidth, buttonHeight), "start!")) {  
				reset ();
				RoundController.run = true;
				//GUI.Button (new Rect(buttonX * 0.25f,buttonY * 0.25f,buttonWidth,buttonHeight),"");
				//GUI.Label (new Rect (buttonX,buttonY * 0.25f,buttonWidth,buttonHeight), "Round " + RoundController.round);
				Debug.Log ("Start!");
				++game;
			}
		} else if (game == 1) {
			GUI.Label (new Rect (buttonX, buttonY * 0.25f, buttonWidth, buttonHeight), "Round " + RoundController.round);
		} else if (game >= 2 && game <= 10) {
			RoundController.run = true;
			GUI.Label (new Rect (buttonX, buttonY * 0.25f, buttonWidth, buttonHeight), "Round " + RoundController.round);
		} else if(game == 11){
			if (GUI.Button (new Rect (buttonX, buttonY, buttonWidth, buttonHeight), "restart!")) {
				game = 0;
			}
		}
	} 

	//reset game
	void reset(){
		DiskFactory.UFO = 0;
		ScoreRecoder.total = 0;
		RoundController.limit = 2.0f;
		RoundController.timer = 0;
		RoundController.run = false;
		RoundController.round = 1;
	}
}
