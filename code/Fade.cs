using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fade : MonoBehaviour
{


    public float speed = 0.01f;  //透明化の速さ
    float alfa;    //A値を操作するための変数
    float red, green, blue;    //RGBを操作するための変数
    public int Clear = 0; //未クリア状態
    public Timer timer;
    float btime;

    // Start is called before the first frame update
    void Start()
    {
        //Panelの色を取得
        red = GetComponent<Image>().color.r;
        green = GetComponent<Image>().color.g;
        blue = GetComponent<Image>().color.b;



    }

    // Update is called once per frame
    void Update()
    {
        btime = timer.currentTime;
        if (Clear == 1)//クリア状態ならば
        {
          

            GetComponent<Image>().color = new Color(red, green, blue, alfa);
            alfa += speed;
           
            if (alfa >= 1) //alfaは０〜１だが１以上でも１の透明度なので時間差もかねて
            {
                Time.timeScale = 1f;    //時間再開
                SceneManager.LoadScene("Clear");
            }
        }


       
       else if (btime <= 0.0f)
        {
            GetComponent<Image>().color = new Color(red, green, blue, alfa);
            alfa += speed;
           
            if (alfa >= 1) //alfaは０〜１だが１以上でも１の透明度なので時間差もかねて
            {
                 Time.timeScale = 1f;
                SceneManager.LoadScene("Over");
            }

        }
    }
}
