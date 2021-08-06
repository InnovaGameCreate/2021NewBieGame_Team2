using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    bool isCountdownStart;
    bool eraserUp = true;
    public Text text;
    public Canvas canvas;
    public Text timerText;
    private float a = 3.0f;
    public float timer;
    public float countdown = 5.0f;
    public GameObject main;
    private Main mainCs;

    // Start is called before the first frame update
    void Start()
    {
        main = GameObject.Find("Main");//変数mainに”Main”という名前のオブジェクトを見つけて入れる
        mainCs = main.GetComponent<Main>();//変数mainCsにオブジェクトmainについているMainというというスクリプトを入れる
    }

    // Update is called once per frame
    void Update()
    {
        if (mainCs.eraser <= 1)
        {
            if (Input.GetKeyDown(KeyCode.T))
            {
                Debug.Log("a");
                isCountdownStart = true;
            }
        }

        timerText.text = countdown.ToString("f1") + "秒";
        text.enabled = false;

        if (isCountdownStart && countdown > -3.0f)
        {
            countdown = countdown - Time.deltaTime;
        }

        if (countdown > -3 && countdown <= 0)
        {
            if (a >= -5)
            {
                a = a - Time.deltaTime;
            }
            text.enabled = true;
            canvas.enabled = false;
            isCountdownStart = false;
            Debug.Log("このタイミングで消しゴムの数をカウント");
            if (eraserUp == true)
            {
                mainCs.eraser = mainCs.eraser + 1;
                eraserUp = false;
            }
        }

        if (a <= 0)
        {
            text.enabled = false;
            Debug.Log("「消しゴムを手に入れた！」を消す");
        }

        if (mainCs.eraser >= 2)
        {
            canvas.enabled = false;
        }
    }
}
