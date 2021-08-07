using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeftToResult : MonoBehaviour
{
    public float LeftTime;//Leftに来てからの時間
    public float alertTime; //振り向く時間
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
        LeftTime = LeftTime + Time.deltaTime;
        alertTime = Random.Range(8.0f, 15.0f);
        if (LeftTime > alertTime && alertCalledOnce == false)
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
