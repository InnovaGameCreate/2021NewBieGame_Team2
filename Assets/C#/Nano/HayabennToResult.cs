using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HayabennToResult : MonoBehaviour
{
    public float HayabennTime; //Hayabennに来てからの時間
    public float alertTime;  //振り向く前になる時間
    bool alertCalledOnce = false; //振り向き音を一回だけ鳴らす

    public AudioClip sound1; //タイムアップ音源
    AudioSource audiosource;

    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>(); //Componentの取得
    }

    // Update is called once per frame
    void Update()
    {
        HayabennTime = HayabennTime + Time.deltaTime;
        alertTime = Random.Range(5.0f, 15.0f);

        if (HayabennTime > alertTime && alertCalledOnce == false)
        {
            audiosource.PlayOneShot(sound1); //警告音を鳴らす
            alertCalledOnce = true; 
            Invoke("ToHurimuitaMethod", 2); //警告の2秒後Hurimuitaへ
        }
    }

    void ToHurimuitaMethod()
    {
        SceneManager.LoadScene("Hurimuita");
    }
}
