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
        if (mainCs.time > 60)
        {
            BGM.PlayOneShot(sound1);
        }
        else
        {
            BGM.PlayOneShot(sound2);
        }
    }
}
