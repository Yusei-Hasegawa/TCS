using UnityEngine;
using System.Collections;

public class TCScamera : MonoBehaviour {
	public float screenW;
	public float screenH;
	// Use this for initialization
	void Start () {
		screenW = Screen.width;
		screenH = Screen.height;
	}

	void OuGUI(){
		if(GUI.Button(new Rect(210,200,40,20),"▼")){
			Application.LoadLevel("TCS");
		}

		if(GUI.RepeatButton(new Rect(200,200,40,20), "前")) {
			Application.LoadLevel("TCS");
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
