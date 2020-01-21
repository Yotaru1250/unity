using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NextClear : MonoBehaviour
{
    [SerializeField]
    private Message messageScript;//暗くするパネルが毎回破壊しているので
    private string message = "  ";//空白のパネルを生成

    public GameObject inventory;//クリア時にインベントリUIを閉じるため
    public GameObject combineButton;
    public Fade fade;
     int bClear;



    // Use this for initialization
    void Start()
    {
        bClear = fade.Clear;//Fade.csのClearを参照
       
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void OnClick()
    {
        messageScript.SetMessagePanel(message);//空のメッセージ表示
        fade.Clear = 1;//クリア状態に変更

       
        Cursor.lockState = CursorLockMode.Confined;//カーソルをウィンドウ内に
        combineButton.SetActive(false);
        inventory.SetActive(false);//インベントリを閉じる

    }


  

}
