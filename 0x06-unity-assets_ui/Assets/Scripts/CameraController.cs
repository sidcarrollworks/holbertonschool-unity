﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

	private const float Y_ANGLE_MIN = -50.0f;
	private const float Y_ANGLE_MAX = 50.0f;

    public Transform lookAt;
    public Transform camTransform;

	// private Camera cam;
    public float distance = 10.0f;

    private float currentX = 0.0f;
    private float currentY = 2.5f;

    public bool isInverted = false;

    private void Start()
    {
        camTransform = transform;
		// cam = Camera.main;
    }

	private void Update() {
		currentX += Input.GetAxis("Mouse X");
		currentY += Input.GetAxis("Mouse Y") * (isInverted ? -1 : 1);

		currentY = Mathf.Clamp(currentY, Y_ANGLE_MIN, Y_ANGLE_MAX);
	}

    private void LateUpdate()
    {
		Vector3 dir = new Vector3(0,0,-distance);
        // if (isInverted) { currentY = -currentY; }
		Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
		camTransform.position = lookAt.position + rotation * dir;
		camTransform.LookAt(lookAt.position);
    }

}
