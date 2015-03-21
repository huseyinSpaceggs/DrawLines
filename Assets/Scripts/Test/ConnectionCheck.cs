using UnityEngine;
using System.Collections;

public class ConnectionCheck : MonoBehaviour {

	public GameObject manager;

	public GameObject[] nodes;

	// Use this for initialization
	void Start () {
		nodes = GameObject.FindGameObjectsWithTag ("Node");
		//nodes [0].GetComponent<Node> ().connectedNodes.Add (nodes[1]);
		Test ();
	}

	void Test () {
		manager.GetComponent<Manager> ().ConnectNodes (nodes[0]);
		manager.GetComponent<Manager> ().ConnectNodes (nodes[1]);
		manager.GetComponent<Manager> ().ConnectNodes (nodes[2]);

	}


}
