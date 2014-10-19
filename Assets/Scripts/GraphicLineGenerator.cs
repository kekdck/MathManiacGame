﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GraphicLineGenerator : MonoBehaviour {
    public string formula;
    LineRenderer lineRenderer;
    [Range(0.0f , 1.0f)] 
    public float bold = 0.2f;
    getVector vector;
    string prevf;
    List<Vector2> points;
	// Use this for initialization
	void Start () {
		vector = this.GetComponent<getVector> ();
		points = vector.getVect(formula);
		lineRenderer = this.GetComponent<LineRenderer>();
        GenerateMesh(new List<Vector2>(points));
	}
	
	// Update is called once per frame
	void Update() {
        
            if (prevf != formula)
            {
                
            }
            prevf = formula;
        
        
	}


    void GenerateMesh(List<Vector2> points)
    {
        lineRenderer.SetVertexCount(points.Count);

        for (int i = 0; i < points.Count; i++)
        {
            lineRenderer.SetPosition(i, points[i]);
        }

        List<Vector2> lowerLine = new List<Vector2>();
        Vector2 vec = new Vector2(0, 0);
        for (int i = 0; i < points.Count - 1; i++)
        {
            vec = points[i] - points[i + 1];
            vec.Normalize();
            vec = Quaternion.AngleAxis(90, Vector3.forward) * vec;
            lowerLine.Add(points[i] + new Vector2(vec.x * bold, vec.y * bold));
        }
        lowerLine.Add(points[points.Count - 1] + new Vector2(vec.x * bold, vec.y * bold));
        lowerLine.Reverse();
        points.AddRange(lowerLine);



        this.GetComponent<PolygonCollider2D>().SetPath(0, points.ToArray());

        
    }
}
