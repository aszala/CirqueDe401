using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BallThrow : MonoBehaviour {

	Rigidbody rb;

	public Slider powerSlider;

	bool cyclePower = true, reverse = false;

	void Start() {
		rb = GetComponent<Rigidbody>();
	}

	void Update() {
		if (cyclePower) {
			if (reverse) {
				powerSlider.value -= 0.02f;
			} else {
				powerSlider.value += 0.02f;
			}

			if (powerSlider.value >= 1)
				reverse = true;
			else if (powerSlider.value <= 0)
				reverse = false;
		}

		if (Input.GetMouseButtonDown(0)) {
			cyclePower = false;

			float power = powerSlider.value;

			rb.useGravity = true;

			rb.AddForce(new Vector3(0, 2000000 * power, 3500000 * power));
		}
	}

	public void restart() {
		SceneManager.LoadScene("CupKnockDown");
	}
}
