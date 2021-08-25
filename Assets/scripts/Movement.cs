using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	void Start() {

	}

	void Update() {
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		float rotateHorizontal = Input.GetAxis("Mouse X");
		transform.RotateAround(transform.position, -Vector3.up, -rotateHorizontal * 2.0f);

		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical) * 5.0f * Time.deltaTime;

		transform.Translate(movement);

	}
}
