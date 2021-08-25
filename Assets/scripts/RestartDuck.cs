using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartDuck : MonoBehaviour {
	public void restart() {
		SceneManager.LoadScene("DuckShooting");
	}
}
