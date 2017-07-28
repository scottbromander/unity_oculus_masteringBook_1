using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			gameObject.transform.Translate (transform.forward * Time.deltaTime);
		} 
		if (Input.GetKey (KeyCode.S)) {
			gameObject.transform.Translate (-transform.forward * Time.deltaTime);
		} 
		if (Input.GetKey (KeyCode.A)) {
			gameObject.transform.Translate (-transform.right * Time.deltaTime);
		} 
		if (Input.GetKey (KeyCode.D)) {
			gameObject.transform.Translate (transform.right * Time.deltaTime);
		} 
	}
}
