using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RoundController : MonoBehaviour {
	private System.Random rd = new System.Random ();
	public static int round = 1;
	private GameObject l1, l2, l3;
	//state
	public static Boolean run = false;
	public static float timer = 0;
	public static float limit = 2.0f;
	//start
	void start(){
		
	}

	void Update(){
		timer = Time.time;
		if (run == true && timer >= limit && DiskFactory.UFO < 10) {
			roundstart ();
			limit = timer + 2;
		}
		if (DiskFactory.UFO == 10 && timer >= limit) {
			limit = timer + 2;
			DiskFactory.UFO = 0;
			resetround ();
			++MyGUI.game;
			++round;
		}
	}
	//reset round
	void resetround(){
		run = false;
		timer = 0;
	}

	//reset
	void reset(){
		//Time
		timer = 0;
		run = false;
		limit = 2.0f;
		round = 1;
	}

	//load prefabs
	void roundstart(){
		int choice = rd.Next (1, 4);
		DiskFactory.getUFO (choice);
		++DiskFactory.UFO;
		//l1 = Instantiate(Resources.Load("Prefabs/lv1"), new Vector3(-13, 0, 0), Quaternion.identity) as GameObject;
		//l2 = Instantiate(Resources.Load("Prefabs/lv2"), new Vector3(-13, 0, 0), Quaternion.identity) as GameObject;
		//l3 = Instantiate(Resources.Load("Prefabs/lv3"), new Vector3(-13, 0, 0), Quaternion.identity) as GameObject;
	}
}
