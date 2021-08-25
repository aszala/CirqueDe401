using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaterGunAim : MonoBehaviour {

	void Start() {

	}

	void Update() {
		transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X"), -Input.GetAxis("Mouse Y")) * Time.deltaTime * 50.0f);
		transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, transform.eulerAngles.z);
	}

	public void Restart() {
		SceneManager.LoadScene("WaterRace");
	}
}
