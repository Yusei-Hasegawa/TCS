using UnityEngine;
using System.Collections;

public class MoveCube : MonoBehaviour {

		public float screenW;
		public float screenH;
		
		void Start() {
			screenW = Screen.width;
			screenH = Screen.height;
			//controller = GetComponent<CharacterController>();
		}
		
		void OnGUI() {
			
			if(GUI.RepeatButton(new Rect(screenW-screenW+45,screenH-70,60,20), "戻る")) {
				Application.LoadLevel("TCS");
			}
		}
	}

