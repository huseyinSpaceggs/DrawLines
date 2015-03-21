using UnityEngine;
using System.Collections;

public class DrawLine1 : MonoBehaviour {



	bool isDraw = false;

	// Update is called once per frame
	void Update () {
	
	}



	public void StartDrawing (Vector3 startPoint , Vector3 endingPoint , float time) {
		print ( endingPoint + "da biter , ve " + time + " sn sürer!" );
		if (!GetComponent<LineRenderer> ())
						Debug.LogError ("Line renderer koymayı unutmuşun!!");
		else{
			GetComponent<LineRenderer>().SetPosition(0,startPoint);
			GetComponent<LineRenderer>().SetPosition(1,endingPoint);

		}
	}



}
