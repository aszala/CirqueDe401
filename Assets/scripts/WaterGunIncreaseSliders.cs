using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaterGunIncreaseSliders : MonoBehaviour {

	List<GameObject> objects = new List<GameObject>();

	public Slider slider;

	public GameObject over;

	void Start() {
		over.SetActive(false);
		Cursor.visible = false;
	}
	
	void Update() {
		if (!over.activeSelf) {
			if (objects.Count > 0) {
				if (transform.name.Contains("1"))
					slider.value += 0.015f;
				else
					slider.value += 0.01f;
			}

			if (slider.value >= 1) {
				over.SetActive(true);
				Cursor.visible = true;
			}
		}
	}

	void OnTriggerEnter(Collider collision) {
		if (collision.gameObject.name.Contains("Water"))
			objects.Add(collision.gameObject);
	}

	void OnTriggerExit(Collider collision) {
		objects.Remove(collision.gameObject);
	}
}
