using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class RigidbodyMover : MonoBehaviour {
	Rigidbody rb;

	[SerializeField] Vector3 force;
	[SerializeField] ForceMode mode;

	[SerializeField] Vector3 torque;
	[SerializeField] ForceMode torqueMode;

	[SerializeField] KeyCode jumpKey;

	private void Start() {
		rb = GetComponent<Rigidbody>();
	}

	private void Update() {
		if (Input.GetKeyDown(jumpKey)) {
			rb.AddForce(Vector3.up * 10, ForceMode.Impulse);
		}
	}

	private void FixedUpdate() {
		if (Input.GetKey(KeyCode.Space)) {
			rb.AddForce(force, mode);
			rb.AddTorque(torque, mode);
		}
	}
}