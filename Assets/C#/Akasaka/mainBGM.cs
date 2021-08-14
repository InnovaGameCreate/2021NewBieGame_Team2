using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainBGM : MonoBehaviour
{
    private GameObject main;
    private Main mainCs;

    public AudioClip sound1;
    public AudioClip sound2;

    AudioSource BGM;
    AudioSource oneminBGM;

    bool bgm0CalledOnce = false;
    bool bgmCalledOnce = false;
    bool bgm2CalledOnce = false;
    bool bgmSet = true;

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
        if (bgmSet == true)
        {
            if (SceneManager.GetActiveScene().name != "Result2")
            {
                if(bgm0CalledOnce == false)
                {
                    BGM.PlayOneShot(sound1);
                    Debug.Log("A");
                    bgm0CalledOnce = true;
                }

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

            if (SceneManager.GetActiveScene().name == "Result2")
            {
                if (bgm2CalledOnce == false)
                {
                    oneminBGM.Stop(); //BGM‚ðŽ~‚ß‚é
                    bgm2CalledOnce = true;
                    bgmSet = false;
                }
            }
        }

        if(SceneManager.GetActiveScene().name == "Setumei")
        {
            if(Input.GetKey(KeyCode.Return))
            {
                bgm0CalledOnce = false;
                bgmCalledOnce = false;
                bgm2CalledOnce = false;
                bgmSet = true;
            }
        }
       
    }
}
