using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NextGame : MonoBehaviour {
	[SerializeField]
	private GameObject pauseUI;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnClick() {

	if(pauseUI.activeSelf) {
      pauseUI.SetActive (!pauseUI.activeSelf);
    	Time.timeScale = 1f;
		Cursor.visible = false;	
	 }
	}

}
