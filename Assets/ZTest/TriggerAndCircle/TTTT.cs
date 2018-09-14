using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TTTT : MonoBehaviour {
	//public Transform target;
	// Use this for initialization


	public Vector3 centerPt;
	public float radius = 2f;
	public float speed = 2f;
	void Update() {
		float dirX = 0;
		if (Input.GetMouseButtonDown (0)) {
			dirX = -1f;
		} else if (Input.GetMouseButtonDown (0)) {
			dirX = +1f;
		}

		Vector3 movement = new Vector3(dirX, Input.GetAxis("Vertical"), 0);
		Vector3 newPos = transform.position + movement;
		Vector3 offset = newPos - centerPt;
		transform.position = centerPt + Vector3.ClampMagnitude(offset, radius);
	}
}
