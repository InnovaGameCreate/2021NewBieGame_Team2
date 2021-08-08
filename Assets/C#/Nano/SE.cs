using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SE : MonoBehaviour
{
    public GameObject main;
    private Main mainCs;
    private AudioSource hanashikakeru;
    bool seCalledOnce = false; //seを一回だけ呼ぶ
    AudioSource audiosource;

    // Start is called before the first frame update
    void Start()
    {
        hanashikakeru = GetComponent<AudioSource>();

        main = GameObject.Find("Main");//変数mainに”Main”という名前のオブジェクトを見つけて入れる
        mainCs = main.GetComponent<Main>();//変数mainCsにオブジェクトmainについているMainというというスクリプトを入れる

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T) && seCalledOnce == false)
        {
            hanashikakeru.PlayOneShot(hanashikakeru.clip);
            seCalledOnce = true;
        }

        if (mainCs.eraser >= 2)
        {
            hanashikakeru.Stop();
        }
    }
}
