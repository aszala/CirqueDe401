using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DuckMoveScript : MonoBehaviour {

	public enum OccilationFuntion { Sine, Cosine }

	float currentX = 0;

	public GameObject ducks;
	public GameObject gameOver;

	public void Start() {
		currentX = transform.position.x;

		if (Random.value > 0.5)
			StartCoroutine(Oscillate(OccilationFuntion.Sine, 4f));
		else
			StartCoroutine(Oscillate(OccilationFuntion.Cosine, 4f));

		gameOver.SetActive(false);
	}

	private IEnumerator Oscillate(OccilationFuntion method, float scalar) {
		while (true) {
			if (method == OccilationFuntion.Sine) {
				transform.position = new Vector3(Mathf.Sin(Time.time) * scalar + currentX, transform.position.y, transform.position.z);
			} else if (method == OccilationFuntion.Cosine) {
				transform.position = new Vector3(Mathf.Cos(Time.time) * scalar + currentX, transform.position.y, transform.position.z);
			}

			yield return new WaitForEndOfFrame();
		}

	}

	void OnMouseDown() {
		if (ducks.transform.childCount-1 == 0) {
			gameOver.SetActive(true);
		}

		Destroy(this.gameObject);
	}

}
