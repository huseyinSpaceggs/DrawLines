using UnityEngine;
using System.Collections;
using System.Collections.Generic;



public class Manager : MonoBehaviour {

	
	public GameObject[] connections;
	public GameObject[] connections2;

	public GameObject[] nodes;
	public GameObject lastClicked;

	void Awake () {
		nodes = GameObject.FindGameObjectsWithTag ("Node");

	}

	void Start () {
		if (connections.Length != connections2.Length)
						Debug.LogError ("connection arraylerinin boyları eşit değil!");;
	}


	public void ConnectNodes(GameObject newNode){
		if (lastClicked != null) {
			print("ConnectNodes(GameObject newNode)");
			newNode.GetComponent<Node>().Connect(lastClicked);
			lastClicked.GetComponent<Node>().Connect(newNode);

		}else{
			newNode.GetComponent<Node>().Connect();
			lastClicked = newNode;
		}
	}

	public void Check (GameObject node) {

		StartCoroutine (DrawLine(1f , lastClicked , node ));
		lastClicked = node;
	}

	IEnumerator DrawLine(float waitingTime, GameObject startNode,GameObject endNode){
		Debug.Log ("draw line between" + startNode.name + " - " + endNode.name);
		yield return new WaitForSeconds (waitingTime);
		StartCoroutine (CheckForFinish(1f));
	}


	IEnumerator CheckForFinish(float waitingTime){

		yield return new WaitForSeconds (waitingTime);

		bool isFinished = true;
		foreach (GameObject obj in nodes) {
			if(obj.GetComponent<Node>().isClicked == false)
				isFinished = false;
		}

		for (int i = 0; i< connections.Length; i++) {
			/*
				
				if( connections[i] is not connected to connections2[i]  )
					isfinished = false;
			 */
		}


		if (isFinished) {
			UnlockNextLevel();
			ChangeNextLevel();
		}

	}

	void ChangeNextLevel(){
		print ("ChangeNextLevel");
	}

	void UnlockNextLevel(){
		print ("UnlockNextLevel");
	}

}
