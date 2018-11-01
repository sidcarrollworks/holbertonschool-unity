using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed = 0.5f;
	public float jumpForce = 1f;
	public float gravity = 7f;
	private Vector3 direction = Vector3.zero;
	private CharacterController controller;

	private Camera camRot;
	private Transform player;

	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController>();
		camRot = Camera.main;
		player = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		if (player.position.y < -25.0f) {
			player.position = new Vector3(0.0f, 20.0f, 0.0f);
		}

		if (controller.isGrounded) {
			direction = new Vector3 (Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
			direction = Vector3.ClampMagnitude(direction, 1);
			direction = transform.TransformDirection(direction);
			direction *= speed;

			if (Input.GetButtonDown("Jump")) {
				direction.y = jumpForce;
			}
			
		}

		direction.y -= gravity * Time.deltaTime;

		player.rotation = camRot.transform.rotation;
		controller.Move(direction);
	}
}
