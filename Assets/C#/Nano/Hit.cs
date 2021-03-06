using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Hit : MonoBehaviour
{
    private GameObject main;
    private Main mainCs;
    public AudioClip sound1; //当たった音源
    AudioSource audiosource;
    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>(); //Componentの取得
        audiosource.PlayOneShot(sound1);  //消しゴム投げSE
        main = GameObject.Find("Main");
        mainCs = main.GetComponent<Main>();
        mainCs.eraser = mainCs.eraser - 1;
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("ToMainMethod", 2);
    }

    void ToMainMethod()
    {
        SceneManager.LoadScene("Main");
    }
}
