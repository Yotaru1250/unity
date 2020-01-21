using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class firstitem : MonoBehaviour
{
    [SerializeField]
    private Message messageScript;
    public GameObject Inspect;
    public GameObject[] inventoryButton = new GameObject[8];  //これはボタンの配列
    public Changeimage[] item = new Changeimage[8]; //これはボタンのスクリプトの配列　スクリプトは１つだが、どのボタンのスクリプトを使うかはわからないため
    public Timer timer;
    public Changeimage changeimage;
    public int  text;
    float dec = 20;
   
    //　表示させるメッセージ
   



    // Start is called before the first frame update
    void Start()
    {
        dec = timer.gameTime;
        Inspect.SetActive(false);
        //inventoryButton = GameObject.Find("Button001");
        // item = inventoryButton.GetComponent<Changeimage>();


        inventoryButton[0].SetActive(true);

        item[0].id3();

       



    }

    // Update is called once per frame
    void Update()
    {

    }



  
}
