using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class RigidbodyController : MonoBehaviour {

	[SerializeField] float speed = 1;
	[SerializeField] float angulerSpeed = 1;
	[SerializeField] Space space = Space.World;
	[SerializeField] ForceMode mode;
	[SerializeField] ForceMode torqueMode;

	Rigidbody rb;

	Vector3 force = Vector3.zero;
	Vector3 torque = Vector3.zero;

	private void Start() {
		rb = GetComponent<Rigidbody>();
	}

	void Update() {
		Vector3 direction = Vector3.zero;
		float rotation = 0;

		if (space == Space.World) direction.x = Input.GetAxis("Horizontal");
		else { rotation = Input.GetAxis("Horizontal"); }

		direction.z = Input.GetAxis("Vertical");
		direction = Vector3.ClampMagnitude(direction, 1);

		force = direction * speed;
		torque = Vector3.up * rotation * angulerSpeed;
		//transform.rotation = Quaternion.Euler(0, rotation speed, 0);
		//transform.Translate(direction * speed * Time.deltaTime, space);
	}

	void FixedUpdate() {
		rb.AddRelativeForce(force, mode);
		rb.AddTorque(torque, torqueMode);
	}

	private void OnDrawGizmos() {
		Gizmos.color = Color.blue;
		Gizmos.DrawRay(transform.position, transform.forward);
		Gizmos.color = Color.red;
		Gizmos.DrawRay(transform.position, transform.right);
		Gizmos.color = Color.green;
		Gizmos.DrawRay(transform.position, transform.up);
	}
}