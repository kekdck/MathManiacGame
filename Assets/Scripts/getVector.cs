using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class getVector : MonoBehaviour {

    public float delta = 1.0f;
	// Use this for initialization
    Vector2 newPoint = new Vector2(0, 0);

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

	public List<Vector2> getVect(string s){
		List<Vector2> list = new List<Vector2> ();
		string ss;
        for (double i = -20; i < 20; i += 0.5f)
        {
            if(i == 0)
            {
                i = 0.01;
            }
			ss = s.Replace("-x", "x*-1");
            string numstr;
            if(i < 0)
            {
                numstr = (-i).ToString() + "*-1";
            }
            else
            {
                numstr = i.ToString();
            }
            
			ss = ss.Replace("x", numstr);
            newPoint.x = (float)i;
            newPoint.y = (float)getValue(ss);
            if(list.Count == 0 || 
                Vector2.Distance(list[list.Count - 1], newPoint) > 0.1f)
            {
                list.Add(newPoint);
            }

		}
		return list;
	}

 	// Update is called once per frame
	void Update () {
	
	}
}
