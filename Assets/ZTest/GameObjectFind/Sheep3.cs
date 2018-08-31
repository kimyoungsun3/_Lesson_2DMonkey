using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sheep3 : MonoBehaviour {
	public float x1;
	public Vector3 v1;


	public void InvokeDisplay(int _idx){
		Debug.Log (_idx + " > " + x1 + " , " + v1);
	}
}

