using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
	[SerializeField] GameObject ragdollPrefab;
	[SerializeField] KeyCode keyCode;

	private void Update() {
		if (Input.GetKeyDown(keyCode)) {
			Instantiate(ragdollPrefab, this.transform.position, this.transform.rotation);
		}
	}
}
