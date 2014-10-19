﻿using UnityEngine;
using System.Collections;

public class MainSphere : MonoBehaviour {

	Vector3 initalPos;
    Vector3 beginPos;
	bool isCanMove = false;
    public GameObject portal;
	// Use this for initialization
	void Start () {
		initalPos = transform.position;
        beginPos = transform.position;
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
        if ( (transform.position.y < 0) )
        {
            initalPos = beginPos;
            isCanMove = false;

        }
        if(transform.position.y < 0)
        {
            isCanMove = false;

        }
		if (Input.GetKeyDown (KeyCode.R)) 
		{
            initalPos = beginPos;
			isCanMove = false;
		}
	}
}
