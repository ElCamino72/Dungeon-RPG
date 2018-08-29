using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
	private Transform playerTransform;

	// Use this for initialization
	void Start () {
		// Grab Player Transform
		playerTransform = GameObject.FindWithTag ("Player").GetComponent <Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void LateUpdate () {
		Vector3 playerPosition = playerTransform.position;
		transform.SetPositionAndRotation (playerPosition, transform.rotation);
	}
}
