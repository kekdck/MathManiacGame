using UnityEngine;
using System.Collections;

public class LevelState : MonoBehaviour {

	public string formula = "";
	static char[] mixedFormula;

	// Use this for initialization
	void Start () {
		mixedFormula = shuffleString(formula);
		while (formula.ToCharArray() == mixedFormula) {
			mixedFormula = shuffleString(formula);
		}
	}

	char[]	 shuffleString(string str)
	{
		char[] mixedArray = str.ToCharArray();
		int n = mixedArray.Length;  
		while (n > 1) {  
			n--;  
			int k = Random.Range(0, n + 1); 
			Random.Range(0, n + 1);
			char value = mixedArray[k];  
			mixedArray[k] = mixedArray[n];  
			mixedArray[n] = value;  
		}  
		return mixedArray;
	}
	
	// Update is called once per frame
	void Update () {
	}

	static public char[] Formula {
		get {
			return mixedFormula;
		}
	}
}
