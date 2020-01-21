using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Parts2 : MonoBehaviour
{
    [SerializeField]
    public Message messageScript;
    public GameObject Inspect;
    public GameObject[] inventoryButton = new GameObject[7];  //これはボタンの配列
    public Changeimage[] item = new Changeimage[7]; //これはボタンのスクリプトの配列　スクリプトは１つだが、どのボタンのスクリプトを使うかはわからないため
    public Timer timer;
    float dec = 20;
    bool One;
    public Changeimage changeimage;
    int count;
    public int text;
    //　表示させるメッセージ
    private string message = "    ２を入手した";



    // Start is called before the first frame update
    void Start()
    {
        dec = timer.gameTime;
        Inspect.SetActive(false);
        //inventoryButton = GameObject.Find("Button001");
        // item = inventoryButton.GetComponent<Changeimage>();
        One = true;
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void OnTriggerStay(Collider collider)
    {

        if (collider.gameObject.tag == "Player")
        {
            if (One)
            {
                Inspect.SetActive(true);

                if (Input.GetKeyDown(KeyCode.E))
                {
                    messageScript.SetMessagePanel(message);

                    int i;
                    for (i = 0; i < 8; i++)
                    {
                        if (inventoryButton[i].activeSelf == false) //空だったら表示する　この時点では真っ白（デフォ）
                        {
                            inventoryButton[i].SetActive(true);
                            item[i].id2();
                            One = false; //一度だけ表示
                            Inspect.SetActive(false);//テキストを消す　これが無いと離れるまでテキストが消えない

                            count = changeimage.Count;
                            changeimage.Count = count + 1;
                            Debug.Log(changeimage.Count);
                            break; //表示したらあとはしない
                        }
                    }

                    //inventoryButton.SetActive(true);
                    //Debug.Log(inventoryButton.transform.position.x);

                    /* Vector3 pos = inventoryButton.transform.position;
                     pos.x -= 100;
                     inventoryButton.transform.position = pos;
                     Debug.Log(inventoryButton.transform.position.x);
                     */

                }
            }
        }

    }

    public void OnTriggerExit(Collider collider)
    {

        if (collider.gameObject.tag == "Player")
        {
            Inspect.SetActive(false);

        }
    }
}
