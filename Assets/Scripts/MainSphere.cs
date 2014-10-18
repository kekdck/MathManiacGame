using UnityEngine;
using System.Collections;

public class MainSphere : MonoBehaviour {

	Vector3 initalPos;
	bool isCanMove = false;
	// Use this for initialization
	void Start () {
		initalPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (!isCanMove) 
		{
			transform.position = initalPos;
			rigidbody2D.velocity = Vector2.zero;
		}
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			isCanMove = true;
			rigidbody2D.AddForce(new Vector3(100.0f, 0.0f, 0.0f));
		}
		if (Input.GetKeyDown (KeyCode.R)) 
		{
			isCanMove = false;
		}
	}
}
