using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiskFactory : MonoBehaviour {
	public static int UFO = 0;
	private static GameObject l1, l2, l3;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//reset
	void reset(){
		UFO = 0;
	}

	//get
	public static void getUFO(int choice){
		switch (choice) {
		case 1:
			l1 = Instantiate (Resources.Load ("Prefabs/lv1"), new Vector3 (-13, 0, 0), Quaternion.identity) as GameObject;
			break;
		case 2:
			l2 = Instantiate (Resources.Load ("Prefabs/lv2"), new Vector3 (-13, 0, 0), Quaternion.identity) as GameObject;
			break;
		case 3:
			l3 = Instantiate (Resources.Load ("Prefabs/lv3"), new Vector3 (-13, 0, 0), Quaternion.identity) as GameObject;
			break;
		}
	}
}
