using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour {

	// Use this for initialization
	private bool followMyMouse;
	private Transform tr;
	void Start () {
		followMyMouse = false;
		tr = this.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (followMyMouse == false) {
			return;
		}//else keeps following the mouse's position
		Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		mousePos.z = 0;
		//now thange the position of transform
		tr.position = mousePos;
	}
	public void startFollowing() {
		followMyMouse = true;
	}
	public void stopFollowing() {
		followMyMouse = false;
	}
}
