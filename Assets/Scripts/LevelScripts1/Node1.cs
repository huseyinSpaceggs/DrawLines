using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Node1 : MonoBehaviour {

	public List<GameObject> connected = new List<GameObject>();

	public Sprite selectedSprite;
	public Sprite nonselectedSprite;

	void OnMouseDown() {



		print ("HI - OnMouseDown");
		Controls1 control = GameObject.FindGameObjectWithTag ("Manager").GetComponent<Controls1> ();

		if(control.selected != gameObject){

			if(control.selected == null)
				control.OnFingerDown (gameObject);

			if(	control.selected !=null	&& !control.selected.GetComponent<Node1>().connected.Contains(gameObject))
				control.OnFingerDown (gameObject);
		}
	
	}





	public void ConnectToNode (GameObject node) {
		if (!connected.Contains (node)) {

			connected.Add (node);

			print ( gameObject.name + " connected to -> " + node.name);

		}
				else
						print (node.name + " is already connected to -> " + gameObject.name );
	}



}
