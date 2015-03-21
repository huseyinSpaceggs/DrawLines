using UnityEngine;
using System.Collections;

public class Manager1 : MonoBehaviour {

	public GameObject[] connections1;
	public GameObject[] connections2;



	public string nextLevel;

	void Start () {
		if (connections1.Length != connections2.Length)
			Debug.LogError ("connection arraylerinin boyları eşit değil!");;

	}
	
	public void CheckForFinish () {
		bool isFinished = true;

		for (int i = 0; i< connections1.Length; i++) {
			if ( !connections1[i].GetComponent<Node1>().connected.Contains(connections2[i]) )
				isFinished= false;

		}

		if (isFinished) {
			if(nextLevel == "")
				print("Game Ended -> Continue to next level!");
			else
				Application.LoadLevel(nextLevel);
		}

	}

}
