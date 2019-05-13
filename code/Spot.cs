using UnityEngine;
using System.Collections;


public class Spot : MonoBehaviour {

GameObject cam;
GameObject spotLight;
bool lightEnable = true;

	// Use this for initialization
	void Start () {
		cam = transform.Find("FirstPersonCharacter").gameObject;
		spotLight = transform.Find("Spot Light").gameObject;
	}
	
	// Update is called once per frame
	void Update () {
// Spotlightの回転角をカメラと同じにするだけです
spotLight.transform.rotation = cam.transform.rotation;
	}
}
