using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Erasercount : MonoBehaviour
{
    public GameObject main;
    private Main mainCs;
    public Text erasercount;

    // Start is called before the first frame update
    void Start()
    {
        main = GameObject.Find("Main");//変数mainに”Main”という名前のオブジェクトを見つけて入れる
        mainCs = main.GetComponent<Main>();//変数mainCsにオブジェクトmainについているMainというというスクリプトを入れる
    }

    // Update is called once per frame
    void Update()
    {
        erasercount.text = mainCs.eraser.ToString() + "個";
    }
}
