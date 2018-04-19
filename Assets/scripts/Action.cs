using System;
using System.Collections;
using UnityEngine;

public class Action : MonoBehaviour {
	//public static Vector3 initpoint = new Vector3 (-13, 0);
	private Vector3 speed = new Vector3 (0.01f, 0.002f, 0);
	private int randomx = 0, randomy = 0, randompos = 0;
	private int hard = 0;
	//Test
	private int x1 = 5, x2 = 15, y1 = 5, y2 = 15;
	public int version = 5;
	//object state
	private Boolean alive = true;
	// Use this for initialization
	void Start () {
		//this.Physics.gravity = new Vector3 (0, -0.1f, 0);
		hard = RoundController.round;
		makepos ();
		this.transform.position = new Vector3(-13, randompos);
		makespeed (x1 + hard * 2, x2 + hard * 2, y1 + hard * 2, y2 + hard * 2);
		speed.x *= randomx;
		speed.y *= randomy;
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.position.x > 13) {
			alive = false;
			Destroy (this.gameObject);
		}
		if (alive == true) {
			//initpoint += speed;
			//this.transform.position = initpoint;
			this.transform.position += speed;
		}
	}

	//make a random speed
	void makespeed(int xup, int xdown, int yup, int ydown){
		System.Random rd = new System.Random ();
		randomx = rd.Next (xup, xdown);
		randomy = rd.Next (yup, ydown);
	}

	//make a initpos
	void makepos(){
		System.Random rd = new System.Random ();
		randompos = rd.Next (-3, 3);
	}

	//mouse task
	void OnMouseDown(){
		alive = false;
		print ("被点击消失");
		addscore ();
		Destroy (this.gameObject);
	}

	//add score by hitting UFO
	void addscore(){
		if (this.name == "lv1(Clone)") {
			ScoreRecoder.total += 5;
		} else if (this.name == "lv2(Clone)") {
			ScoreRecoder.total += 8;
		} else if (this.name == "lv3(Clone)") {
			ScoreRecoder.total += 10;
		}
	}
}
