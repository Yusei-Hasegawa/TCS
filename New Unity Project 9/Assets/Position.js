#pragma strict

public static var CP:Vector3;

function Start () {
	transform.position = CP;
}

function Update () {
	CP = transform.position;
}