using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterTent : MonoBehaviour {

	public string scene;

	void OnTriggerEnter(Collider other) {
		SceneManager.LoadScene(scene);
	}

}
