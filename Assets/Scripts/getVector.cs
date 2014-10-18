using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class getVector : MonoBehaviour {

	// Use this for initialization

	void Start () {
		/*List<Vector2> list = getVect("-x+4");
		int i = 0;
		while (i < list.Count) {
			Debug.Log(list[i] + " ");	
			i++;
		}
		*/
		//Debug.Log (new MathFunctions.MathParser().Calculate("(-x)+3".Replace("x", "3")));
		//Debug.Log (list.Count);
		//Debug.Log (getVect("x+7"));

		//IList<Vector2> list = new IList<> ();


	}

	decimal getValue(string s){
		MathFunctions.MathParser d = new MathFunctions.MathParser ();
		decimal dec = d.Calculate (s);
		return dec;
	}

	List<Vector2> getVect(string s){
		List<Vector2> list = new List<Vector2> ();
		string ss;
		for (double i=0; i<100; i++) {
			ss = s.Replace("-x", "x*-1");

			ss = ss.Replace("x", i.ToString());
			list.Add(new Vector2((float)i,(float)getValue(ss)));

		}
		return list;
	}

 	// Update is called once per frame
	void Update () {
	
	}
}
