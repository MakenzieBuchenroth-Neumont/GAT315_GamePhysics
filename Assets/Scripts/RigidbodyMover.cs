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

	private void Start() {
		rb = GetComponent<Rigidbody>();
	}

	private void Update() {
		if (Input.GetKey(KeyCode.Space)) {
			rb.AddForce(force, mode);
			rb.AddTorque(torque, mode);
		}
	}
}