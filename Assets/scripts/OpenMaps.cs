using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenMaps : MonoBehaviour {

	void Start() {
		Cursor.visible = true;
	}

	public void openScene(string scene) {
		SceneManager.LoadScene(scene);
	}

}
