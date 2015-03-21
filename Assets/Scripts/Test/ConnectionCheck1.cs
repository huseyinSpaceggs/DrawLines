using UnityEngine;
using System.Collections;

public class ConnectionCheck1 : MonoBehaviour {

	Controls1 control;
	Manager1 manager;


	public GameObject[] nodes;


	void Start () {

		manager = GameObject.FindGameObjectWithTag ("Manager").GetComponent<Manager1> ();
		control = GameObject.FindGameObjectWithTag ("Manager").GetComponent<Controls1> ();

		//Test ();

	}
	

	void Test () {
		control.OnFingerDown (nodes[0]);
		control.OnFingerDown (nodes[1]);
		control.OnFingerDown (nodes[2]);
		//control.OnFingerDown (nodes[0]);

	}

}
