using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeUp : MonoBehaviour
{
    public AudioClip sound; //タイムアップ音源
    AudioSource audiosource;
    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>(); //Componentの取得 
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("b");
        audiosource.PlayOneShot(sound);  //時間切れのSE
    }
}
