using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollOnOff : MonoBehaviour {
	public BoxCollider mainCollider;
	public GameObject rig;
	public Animator animator;

	Collider[] ragdollColliders;
	Rigidbody[] ragdollRigidbodies;

	void Start() {
		getRagdollBits();
		ragdollOff();
	}

	void Update() {

	}

	private void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag == "Ball" || collision.gameObject.tag == "Structure") {
			ragdollOn();
		}
	}

	void getRagdollBits() {
		ragdollColliders = rig.GetComponentsInChildren<Collider>();
		ragdollRigidbodies = rig.GetComponentsInChildren<Rigidbody>();
	}

	void ragdollOn() {
		animator.enabled = false;
		foreach (Collider collider in ragdollColliders) {
			collider.enabled = true;
		}
		foreach (Rigidbody rigid in ragdollRigidbodies) {
			rigid.isKinematic = false;
		}
		mainCollider.enabled = false;
		GetComponent<Rigidbody>().isKinematic = true;
	}

	void ragdollOff() {
		foreach(Collider collider in ragdollColliders) {
			collider.enabled = false;
		}
		foreach(Rigidbody rigid in ragdollRigidbodies) {
			rigid.isKinematic = true;
		}
		animator.enabled = true;
		mainCollider.enabled = true;
		GetComponent<Rigidbody>().isKinematic = false;
	}
}
