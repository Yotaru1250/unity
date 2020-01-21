using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Changeimage : MonoBehaviour
{
   
    SpriteRenderer MainSpriteRenderer;
    [SerializeField]
    // publicで宣言し、inspectorで設定可能にする
    private Message messageScript;

    public Sprite Sprite1;//全身
    public Sprite Sprite2;//胴
    public Sprite Sprite3;//頭
    public Sprite Sprite4;//左腕
    public Sprite Sprite5;//右腕
    public Sprite Sprite6;//右足
    public Sprite Sprite7;//左足
    public GameObject[] itemUI = new GameObject[8];



    //public int[] num = { 1,2,3,4,5,6,7};
   

    public int Count = 1;
    public int num;
   

    private string message = "   人形を組み立てますか？　Eキーで組み立てる";

    void Start()
    {
        // このobjectのSpriteRendererを取得
        MainSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();


    }

    // 何かしらのタイミングで呼ばれる
    public void id1()
    {
        this.gameObject.GetComponent<Image>().sprite = Sprite1;
        num = 1;
    }
    public void id2()
    {
        this.gameObject.GetComponent<Image>().sprite = Sprite2;
        num = 2;
    }

    public void id3()
    { 
        this.gameObject.GetComponent<Image> ().sprite = Sprite3;
        num = 3;
    }

    public void id4()
    {
        this.gameObject.GetComponent<Image>().sprite = Sprite4;
        num = 4;
    }

    public void id5()
    {
        this.gameObject.GetComponent<Image>().sprite = Sprite5;
        num = 5;
    }

    public void id6()
    {
        this.gameObject.GetComponent<Image>().sprite = Sprite6;
        num = 6;
       
    }
    public void id7()
    {
        this.gameObject.GetComponent<Image>().sprite = Sprite7;
        num = 7;
    }

    public void OnPointerEnter()//ボタンに侵入
    {

       

        int i;
        for (i = 1; i < 7; i++)
        {
            if (num == 1 && i ==1)
            {
                itemUI[1].SetActive(true);

            }
            else if (num == 2 && i == 2)
                {
                    itemUI[2].SetActive(true);

                }
            else if (num == 3 && i == 3)
            {
                itemUI[3].SetActive(true);

            }
            else if (num == 4 && i == 4)
            {
                itemUI[4].SetActive(true);

            }
            else if (num == 5 && i == 5)
            {
                itemUI[5].SetActive(true);

            }
            else if (num == 6 && i == 6)
            {
                itemUI[6].SetActive(true);

            }
            else if (num == 7 && i == 7)
            {
                itemUI[7].SetActive(true);

            }

        }




        


    }

    public void OnPointerExit()
    {

        int i;
        for (i = 1; i < 7; i++)
        {
            if (num == 1 && i == 1)
            {
                itemUI[1].SetActive(false);

            }
            else if (num == 2 && i == 2)
            {
                itemUI[2].SetActive(false);

            }
            else if (num == 3 && i == 3)
            {
                itemUI[3].SetActive(false);

            }
            else if (num == 4 && i == 4)
            {
                itemUI[4].SetActive(false);

            }
            else if (num == 5 && i == 5)
            {
                itemUI[5].SetActive(false);

            }
            else if (num == 6 && i == 6)
            {
                itemUI[6].SetActive(false);

            }
            else if (num == 7 && i == 7)
            {
                itemUI[7].SetActive(false);

            }
        }



    }


}
