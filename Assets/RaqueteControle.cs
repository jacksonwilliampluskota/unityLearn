using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaqueteControle : MonoBehaviour {
	public Vector3 moveSpeed;
	public float rotSpeed = 5f;

	void Start () {
		//Debug.Log("comecei");
	}
	
	void Update () {
		var hor = Input.GetAxis("Horizontal");
		var ver = Input.GetAxis("Vertical");
		transform.position += hor * moveSpeed * Time.deltaTime;

		var rotZeuler = (ver * Vector3.forward) * rotSpeed * Time.deltaTime;

		transform.rotation *= Quaternion.Euler(rotZeuler);
	}
}
