using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursor : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		Cursor.lockState = CursorLockMode.Confined;
		Cursor.visible = true;
	
	}
}
