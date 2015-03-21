using UnityEngine;
using System.Collections;

public class Controls1 : MonoBehaviour {

	public GameObject selected;
	public GameObject linePrefab;
	Manager1 manager;

	void Awake () {

		manager = GameObject.FindGameObjectWithTag ("Manager").GetComponent<Manager1> ();
	
	}

	public void OnFingerDown(GameObject node) {

		if (selected == null){
			selected = node;
			selected.GetComponent<SpriteRenderer>().sprite= selected.GetComponent<Node1>().selectedSprite;
		}
		else{


			//bunu buraya eklemek pek mantıklı olmaya bilir! = değil zaten
			if(selected.transform.position != node.transform.position )
				Drawline( selected.transform.position , node.transform.position , 1f );

			Debug.LogWarning("ilk hamleden buraya giriyor");

			selected.GetComponent<SpriteRenderer>().sprite= selected.GetComponent<Node1>().nonselectedSprite;
			selected.GetComponent<Node1>().ConnectToNode(node);
			node.GetComponent<Node1>().ConnectToNode(selected);
			selected = node;
			selected.GetComponent<SpriteRenderer>().sprite= selected.GetComponent<Node1>().selectedSprite;
			manager.CheckForFinish();

		}


	}


	void Drawline ( Vector3 start, Vector3 end , float time ) {
		GameObject line = GameObject.Instantiate(linePrefab,start,Quaternion.identity) as GameObject;
		line.GetComponent<DrawLine1> ().StartDrawing(start,end,time);

	}


}
