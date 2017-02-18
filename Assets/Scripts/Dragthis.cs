using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragthis : MonoBehaviour {

	// Use this for initialization
	private Transform tr;
	void Start () {
		tr = this.GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
	}

	public Transform checkIsSelected (Vector3 mousePos){
		foreach (Transform child in tr)//child is a holder, e.g. LeftArmHolder
		{
			foreach (Transform grandChild in child){//grandChild is a specific arm or leg, e.g. LeftLeg of LeftLegSelectable
				if (grandChild.gameObject.tag == "Selectable") {
					if (Vector3.Distance (grandChild.position, mousePos)<= 1) {//!! this may have bug since child object may has relative position
						return grandChild;
					}
				}
			}
		}//finish checking all the selectable
		return null;
	}
}
