using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Cannonball : MonoBehaviour {
	[SerializeField] float force = 1.0f;
	[SerializeField] float lifespan = 0f;

	[SerializeField] ForceMode forceMode;

	[SerializeField] GameObject cannonBall;

	private void Start() {
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}

	private void Update() {
		if (Input.GetMouseButtonDown(0)) {
			GameObject ball = Instantiate(cannonBall, this.transform.position, this.transform.rotation);
			Rigidbody rb = ball.AddComponent<Rigidbody>();
			rb.AddRelativeForce(Vector3.forward * force, forceMode);
			StartCoroutine(RemoveCannonball(ball));
		}
	}

	IEnumerator RemoveCannonball(GameObject ball) {
		yield return new WaitForSeconds(lifespan);
		Destroy(ball);
	}
}
