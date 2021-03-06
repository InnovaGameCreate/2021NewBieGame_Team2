using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InemuriToMain : MonoBehaviour
{
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
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("スコアをカウント");
            mainCs.score = mainCs.score + 0.1f;
        }
    }
}
