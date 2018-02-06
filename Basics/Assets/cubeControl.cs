using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeControl : MonoBehaviour {

	public float speed = 10f;
	Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		//Moving with keys
//		if (Input.GetKey("right")){
//			transform.Translate(0.1f,0,0); 
//		}
//		if (Input.GetKey("left")){
//			transform.Translate(-0.1f,0,0); 
//		}
//		if (Input.GetKey("up")){
//			transform.Translate(0,0,0.1f); 
//		}
//		if (Input.GetKey("down")){
//			transform.Translate(0,0,-0.1f); 
//		}

		//Moving with acceleration (based on how long you hold down the keys)
		//Multiply by time to convert from frames to m/s
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3(horizontal * speed * Time.deltaTime, 0, vertical * speed * Time.deltaTime);
		rb.MovePosition (transform.position + movement);
	}
}
