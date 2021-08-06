using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Eraser : MonoBehaviour
{
    public Text nageru;
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
        Text nageru = this.GetComponent<Text>();// Textコンポーネントを取得
        nageru.color = new Color(0.5f, 0.5f, 0.5f, 1.0f); // 色を指定

        if (mainCs.eraser >= 1)
        {
            nageru.color = new Color(0.0f, 0.0f, 0.0f, 1.0f); // 色を指定
        }
    }
}
