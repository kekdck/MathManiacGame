using UnityEngine;
using System.Collections;

public class Portal : MonoBehaviour {

    private float angleSpeed = 5.0f;
    
	// Use this for initialization
	void Start () {
        ((GameObject)GameObject.FindGameObjectWithTag("WinText")).GetComponent<TextMesh>().renderer.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
	    transform.Rotate(new Vector3(0, 0, angleSpeed));
	}

    void OnTriggerEnter2D(Collider2D c)
    {

            ((GameObject)GameObject.FindGameObjectWithTag("WinText")).GetComponent<TextMesh>().renderer.enabled = true;
    }
}
