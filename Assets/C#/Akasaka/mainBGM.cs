using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainBGM : MonoBehaviour
{
    private GameObject main;
    private Main mainCs;
    public AudioClip sound1;
    public AudioClip sound2;
    AudioSource BGM;
    AudioSource oneminBGM;

    bool bgmCalledOnce = false; 
    bool bgm2CalledOnce = false; 

    // Start is called before the first frame update
    void Start()
    {
        main = GameObject.Find("Main");
        mainCs = main.GetComponent<Main>();

        BGM = GetComponent<AudioSource>();
        oneminBGM = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (mainCs.time <= 60) //1分以下になったら
        {
            if (bgmCalledOnce == false)
            {
                BGM.Stop(); //BGMを止める
                oneminBGM.PlayOneShot(sound2); //残り１分BGMを流す
                bgmCalledOnce = true;
            }
        }

        if (mainCs.time <= 0) //0秒以下になったら
        {
            if (bgm2CalledOnce == false)
            {
                oneminBGM.Stop(); //BGMを止める
                bgm2CalledOnce = true;
            }
        }
    }
}
