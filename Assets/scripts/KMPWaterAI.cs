using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KMPWaterAI : MonoBehaviour {

	void Start() {
		
	}

	void Update() {
		float randX = Random.value / 1.2f;
		float randY = Random.value;

		if (Random.value > Random.value / 1.1)
			randX *= -1;

		if (Random.value > Random.value / 1.1)
			randY *= -1;

		transform.Rotate(new Vector3(0, randX, randY) * Time.deltaTime * 50.0f);
		transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, transform.eulerAngles.z);
	}
}
