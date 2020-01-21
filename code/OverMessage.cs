using UnityEngine;
using System.Collections;
using UnityEngine.UI;



public class OverMessage : MonoBehaviour
{

    //　メッセージUI
    private Text messageText;
    //　表示するメッセージ
    private string message;
    private int page = 1;

    //　1回のメッセージの最大文字数
    [SerializeField]
    private int maxTextLength = 90;
    //　1回のメッセージの現在の文字数
    private int textLength = 0;
    //　メッセージの最大行数
    [SerializeField]
    private int maxLine = 3;
    //　現在の行
    private int nowLine = 0;
    //　テキストスピード
    [SerializeField]
    private float textSpeed = 0.05f;
    //　経過時間
    private float elapsedTime = 0f;
    //　今見ている文字番号
    private int nowTextNum = 0;
    //　マウスクリックを促すアイコン
    private Image clickIcon;
    //　クリックアイコンの点滅秒数
    [SerializeField]
    private float clickFlashTime = 0.2f;
    //　1回分のメッセージを表示したかどうか
    private bool isOneMessage = false;
    //　メッセージをすべて表示したかどうか
    private bool isEndMessage = false;

   
    public GameObject Button;
    void Start()
    {
        clickIcon = transform.Find("Panel/Image").GetComponent<Image>();
        clickIcon.enabled = false;
        messageText = GetComponentInChildren<Text>();
        messageText.text = "";

    }

    void Update()
    {
        Debug.Log(page);
        switch (page)
        {
            case 1:
               
                SetMessagePanel(message);
                SetMessage("ふと気づくと持っていたはずの人形のパーツが無い。\n"
                    + "どこにいったのだろうか。\n"
                    );
                break;

            case 2:
                SetMessagePanel(message);
                SetMessage("その時、あなたは急な睡魔に襲われる。\n" 
                  
                    );
                break;
            case 3:
                SetMessagePanel(message);
                SetMessage("これは誰かの視界なのか・・？\n" +
                    "少女が作業台のようなものに縛られている。\n"
                    );
                break;
            case 4:

                SetMessagePanel(message);
                SetMessage("いやっ・・・助けて・・・！\n" +
                    "少女は言う。\n"
                    );
                break;
            case 5:

                SetMessagePanel(message);
                SetMessage("娘のためだ・・・すまない・・・。" 
                    );
                break;
            case 6:

                SetMessagePanel(message);
                SetMessage("そう言って、男は大きな出刃包丁を取り出した。"
                    );
                break;
            case 7:

                SetMessagePanel(message);
                SetMessage("・・・そして少女の右腕を切り落とした。"
                    );
                break;
            case 8:

                SetMessagePanel(message);
                SetMessage("ーーー泣き叫ぶ少女。\n"　+
                    "男は淡々と脚も切り落としていく。"
                    );
                break;
            case 9:

                SetMessagePanel(message);
                SetMessage("出血かショックか、少女は死んだ。"
                    );
                break;
            case 10:

                SetMessagePanel(message);
                SetMessage("そうして四肢を切り落とした男は少女の首に包丁を下ろした。"
                    );
                break;
            case 11:

                SetMessagePanel(message);
                SetMessage("そしてあなたは目を覚ます。\n" +
                    "やけに現実味のある夢ーーー"
                    );
                break;
            case 12:

                SetMessagePanel(message);
                SetMessage("しかしあなたの手には見覚えのある人形の頭があった。\n" +
                    "ここはーーー。"
                    );
                break;
            case 13:
                Button.SetActive(true);
                SetMessagePanel(message);
                SetMessage("ーーーバッドエンドーーー\n" +
                           "時間がかかりすぎたようです。\n"
                    );
                break;
            default:
               
                SetMessage("");
                break;
        }



        //　メッセージが終わっていない、または設定されている
        if (isEndMessage || message == null)
        {
            return;
        }

        //　1回に表示するメッセージを表示していない 
        if (!isOneMessage)
        {

            //　テキスト表示時間を経過したら
            if (elapsedTime >= textSpeed)
            {
                messageText.text += message[nowTextNum];
                //　改行文字だったら行数を足す
                if (message[nowTextNum] == '\n')
                {
                    nowLine++;
                }
                nowTextNum++;
                textLength++;
                elapsedTime = 0f;

                //　メッセージを全部表示、または行数が最大数表示された
                if (nowTextNum >= message.Length || textLength >= maxTextLength || nowLine >= maxLine)
                {
                    isOneMessage = true;
                }
            }
            elapsedTime += Time.deltaTime;

            //　メッセージ表示中にマウスの左ボタンを押したら一括表示
            if (Input.GetMouseButtonDown(1))
            {
                //　ここまでに表示しているテキストを代入
                var allText = messageText.text;

                //　表示するメッセージ文繰り返す
                for (var i = nowTextNum; i < message.Length; i++)
                {
                    allText += message[i];

                    if (message[i] == '\n')
                    {
                        nowLine++;
                    }
                    nowTextNum++;
                    textLength++;

                    //　メッセージがすべて表示される、または１回表示限度を超えた時
                    if (nowTextNum >= message.Length || textLength >= maxTextLength || nowLine >= maxLine)
                    {
                        messageText.text = allText;
                        isOneMessage = true;
                        break;
                    }
                }
            }
            //　1回に表示するメッセージを表示した
        }
        else
        {

            elapsedTime += Time.deltaTime;

            //　クリックアイコンを点滅する時間を超えた時、反転させる
            if (elapsedTime >= clickFlashTime)
            {
                clickIcon.enabled = !clickIcon.enabled;
                elapsedTime = 0f;
            }

            //　マウスクリックされたら次の文字表示処理
            if (Input.GetMouseButtonDown(1))
            {
                //Debug.Log (messageText.text.Length);
                messageText.text = "";
                nowLine = 0;
                clickIcon.enabled = false;
                elapsedTime = 0f;
                textLength = 0;
                isOneMessage = false;

                //　メッセージが全部表示されていたらゲームオブジェクト自体の削除
                if (nowTextNum >= message.Length)
                {
                    nowTextNum = 0;
                    isEndMessage = true;
                    page++;
                    //transform.GetChild(0).gameObject.SetActive(false);
                    //　それ以外はテキスト処理関連を初期化して次の文字から表示させる
                }

            }
        }








    }

    void SetMessage(string message)
    {
        this.message = message;
    }




    //　他のスクリプトから新しいメッセージを設定
    public void SetMessagePanel(string message)
    {
        SetMessage(message);
        transform.GetChild(0).gameObject.SetActive(true);
        isEndMessage = false;
    }

}

