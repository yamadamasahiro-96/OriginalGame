using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//キャラクター操作
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (-0.02f, 0, 0);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate (0.02f, 0, 0);
		}
		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.Translate (0, 0.02f, 0);
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.Translate (0, -0.02f, 0);
		}
	}
}
