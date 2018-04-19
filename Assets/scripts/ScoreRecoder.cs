using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreRecoder : MonoBehaviour {
	public static int total = 0;
	// Use this for initialization
	void Start () {
		total = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//reset the score
	void reset(){
		total = 0;
	}
}
