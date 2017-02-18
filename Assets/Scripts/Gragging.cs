using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gragging : MonoBehaviour {
	public Dragthis player1;
	public Dragthis player2;
	private Transform selectedObj;
	//private bool selectedSomething;
	// Use this for initialization
	void Start () {
		//selectedSomething = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0) && selectedObj == null) {//haven't selected and we press mouse
			myMouseDown ();

		} else if (!Input.GetMouseButton(0) && selectedObj != null) {//remove the mouse and we have chosen anything
			myMouseUp();
		}
	}

	void myMouseUp () 
	{
		if (selectedObj != null){
			Debug.Log ("leave you");
			selectedObj.GetComponent<FollowMouse>().stopFollowing ();
			selectedObj = null;//reset the selected obj to null, then can use it later
			//selectedSomething = false;
		}
	}
	void myMouseDown () 
	{
		Debug.Log ("got you");
		Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		mousePos.z = 0;//mouse pos = (x, y, 0) for now
		selectedObj = player1.checkIsSelected (mousePos);
		if (selectedObj != null){//mouse selects the thing
			//selectedSomething = true;
			selectedObj.GetComponent<FollowMouse>().startFollowing();

		}
	}



}
