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
        if (mainCs.time <= 60) //1•ªˆÈ‰º‚É‚È‚Á‚½‚ç
        {
            if (bgmCalledOnce == false)
            {
                BGM.Stop(); //BGM‚ðŽ~‚ß‚é
                oneminBGM.PlayOneShot(sound2); //Žc‚è‚P•ªBGM‚ð—¬‚·
                bgmCalledOnce = true;
            }
        }

        if (mainCs.time <= 0) //0•bˆÈ‰º‚É‚È‚Á‚½‚ç
        {
            if (bgm2CalledOnce == false)
            {
                oneminBGM.Stop(); //BGM‚ðŽ~‚ß‚é
                bgm2CalledOnce = true;
            }
        }
    }
}
