using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sheep : MonoBehaviour {

	Transform trans;
	SpriteRenderer render;
	Sheep2 scpSheep2;

	public Sheep3 scpSheep3;
	Sheep3 scpSheep3_2;
	public GameObject goSheep3;

	void Start () {
		trans 		= GetComponent<Transform> ();
		render 		= GetComponent<SpriteRenderer> ();
		scpSheep2 	= GetComponent<Sheep2> ();
		//scpSheep3 	= GetComponent<Sheep3> ();

		scpSheep3_2 = goSheep3.GetComponent<Sheep3> ();
		Debug.Log (trans);
		Debug.Log (render);
		Debug.Log (scpSheep2);
		Debug.Log (scpSheep3 + ":" + scpSheep3_2);
		Debug.Log (scpSheep3 == scpSheep3_2);

		//value
		Vector3 _v1, _v2;
		_v1 = new Vector3 (1f, 2f, 3f);
		_v2 = _v1;
		Debug.Log (_v1 + ":" + _v2);
		_v1.x = 11f;
		Debug.Log (_v1 + ":" + _v2);

		//reference
		//scpSheep3
		//scpSheep3_2
		scpSheep3.InvokeDisplay(1);
		scpSheep3_2.InvokeDisplay (2);

		scpSheep3.x1 = 99f;
		scpSheep3_2.v1 = new Vector3 (77, 777, 7777);

		scpSheep3.InvokeDisplay(11);
		scpSheep3_2.InvokeDisplay (12);

	}

	// Update is called once per frame
	void Update () {
		//goSheep3;
	}
}
