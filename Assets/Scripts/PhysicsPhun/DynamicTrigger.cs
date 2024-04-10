using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DynamicTrigger : MonoBehaviour {
	[SerializeField] GameObject dynamic;

	private void OnTriggerExit(Collider other) {
		if (other.gameObject.tag == "Player") {
			dynamic.SetActive(false);
		}
	}

	private void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Player") {
			dynamic.SetActive(true);
		}
	}
}
