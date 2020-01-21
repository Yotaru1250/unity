using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextMenu : MonoBehaviour {
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}


	 public void OnClick() {
        Time.timeScale = 1f;    //時間再開
        Cursor.lockState = CursorLockMode.Confined;//カーソルをウィンドウ内に
        SceneManager.LoadScene ("Menu");
	 }
}
