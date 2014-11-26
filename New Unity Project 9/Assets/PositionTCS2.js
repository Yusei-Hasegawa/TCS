#pragma strict

function Start () {
	transform.position = Position.CP;
}

function Update () {
	Position.CP = transform.position;
}