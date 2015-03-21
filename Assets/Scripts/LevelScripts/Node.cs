using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Node : MonoBehaviour {

	public bool isClicked = false;

	public List<GameObject> connectedNodes;

	void Start () {
		//connectedNodes = new List<GameObject> ();

	}


	public void Connect (GameObject node){
		//if (node == gameObject)
		//				Debug.LogError ("bağlanmak istenene node, şeçilen obje ile aynı");

		if ( node!=gameObject && !connectedNodes.Contains (node)) {
			print("node!=gameObject &&");
			connectedNodes.Add(node);
			isClicked = true;
			CheckConnections();
		}
	
	}

	public void Connect (){
			isClicked = true;

	}


	void CheckConnections () {
//		Debug.Log ("CheckConnections");
		GameObject.FindGameObjectWithTag ("Manager").GetComponent<Manager> ().Check (gameObject);;
	}




}
