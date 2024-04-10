using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StaticTrigger : MonoBehaviour {
	[SerializeField] GameObject staticText;
	
	private void OnTriggerExit(Collider other) {
		if (other.gameObject.tag == "Player") {
			staticText.SetActive(false);
		}
	}

	private void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Player") {
			staticText.SetActive(true);
		}
	}
}
