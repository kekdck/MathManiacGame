using UnityEngine;
using System.Collections;

public class Portal : MonoBehaviour {

	// Use this for initialization
	void Start () {
        ((GameObject)GameObject.FindGameObjectWithTag("WinText")).GetComponent<TextMesh>().renderer.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D c)
    {
      

            ((GameObject)GameObject.FindGameObjectWithTag("WinText")).GetComponent<TextMesh>().renderer.enabled = true;
    }
}
