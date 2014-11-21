using UnityEngine;
using System.Collections;

public class HM : MonoBehaviour {
	public float screenW;
	public float screenH;

	void Start () {
		screenW = Screen.width;
		screenH = Screen.height;
	}
	
	// Use this for initialization
	void OnGUI () {
		
		if(camera.depth == -2){
			if(GUI.Button(new Rect(screenW-80,screenH-190,40,20),"▲")){
				camera.depth = 2;
				Application.LoadLevel("TCS3");
			}
		}
		if(camera.depth == 2){
			if(GUI.Button(new Rect(screenW-80,screenH-20,40,20),"▼")){
				camera.depth = -2;
				Application.LoadLevel("TCS");
			}
		}
		
	}
	
}