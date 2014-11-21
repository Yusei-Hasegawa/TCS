using UnityEngine;
using System.Collections;

public class Cube : MonoBehaviour {

	public static Vector3 cubeposition;
	
	void start(){

	}
	
	// Update is called once per frame
	void Update () {
		cubeposition = FPC.Position;
	}
}