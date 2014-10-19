using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class getVector : MonoBehaviour
{
    public float delta = 1.0f;
    // Use this for initialization
    Vector2 newPoint = new Vector2(0, 0);

    void Start()
    {
        
    }

	public float evaluateExpresion(string expression) 
	{
		return this.GetComponent<MathEvaluator>().calc(expression);
	}

    public List<Vector2> getVect(string s)
    {
        List<Vector2> list = new List<Vector2>();

        for (float i = -10.0f; i < 10.0f; i += 0.5f)
        {
			string ss = s.Replace("x", i.ToString());
            newPoint.x = i;
            newPoint.y = evaluateExpresion(ss);
            list.Add(newPoint); 
        }
        return list;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
