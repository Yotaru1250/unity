
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Pause : MonoBehaviour {
 
	//　ポーズした時に表示するUI
	[SerializeField]
	private GameObject pauseUI;
   

    // Use this for initialization
    void Start()
    {
 
    }



    // Update is called once per frame
    void Update () {

		Cursor.lockState = CursorLockMode.Confined;
		if (Input.GetKeyDown (KeyCode.Escape)) {
			//　ポーズUIのアクティブ、非アクティブを切り替え
			pauseUI.SetActive (!pauseUI.activeSelf);
			
			
 
			//　ポーズUIが表示されてる時は停止
			if(pauseUI.activeSelf) {
				Time.timeScale = 0f;	//時間停止
				Cursor.visible = true;		//カーソル表示
				Cursor.lockState = CursorLockMode.None;//カーソルのロック解除
				Cursor.lockState = CursorLockMode.Confined;//カーソルをウィンドウ内に
			//　ポーズUIが表示されてなければ通常通り進行
			} 
			else {
				Time.timeScale = 1f;	//時間再開
				Cursor.lockState = CursorLockMode.Confined;//カーソルをウィンドウ内に

            }
		}
	}


	
}