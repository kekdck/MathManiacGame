#pragma strict

function Start () {
	
}

function Update () {

}

function calc(expr)
{
	var res = 0.0f;
	expr = "res=" + expr;
	eval(expr);
	return res;
}