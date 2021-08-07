using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Target : MonoBehaviour
{
    public float score;
    public float xRange;
    public float reloadTime;
    private float reload;
    private GameObject main;
    private Main mainCs;

    public AudioClip sound1; //タイムアップ音源
    AudioSource audiosource;

    // Start is called before the first frame update
    void Start()
    {
        main = GameObject.Find("Main");
        mainCs = main.GetComponent<Main>();

        audiosource = GetComponent<AudioSource>(); //Componentの取得
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)) //右キーが押されたなら
        {
            if (this.transform.position.x <= xRange)
                transform.Translate(new Vector2(10, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))     //左キーが押されたなら
        {
            if (this.transform.position.x >= xRange * -1)
                transform.Translate(new Vector2(-10, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Escape))   //Escapeを押されたら"Main"に戻る
            SceneManager.LoadScene("Main");
        if (mainCs.eraser <= 0)      //eraserが0になったら"Main"に戻る
            Invoke("ToMainMethod", 1);
        if (reloadTime > reload)
            reload = reload + Time.deltaTime;
        else
           if (Input.GetKeyDown(KeyCode.G))
        {
            if (mainCs.eraser >= 1)
            {
                mainCs.eraser = mainCs.eraser - 1; //消しゴム消費
                reload = 0;

                audiosource.PlayOneShot(sound1);  //消しゴム投げSE
                
            }

        }
    }
   
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "wig")
        {
            if (reloadTime > reload)
                reload = reload + Time.deltaTime;
            else
            {
                if (Input.GetKeyDown(KeyCode.G))
                {
                    if (mainCs.eraser >= 1)
                    {
                        mainCs.score = mainCs.score + 1000; Debug.Log("当たった");  //スコア加算
                        reload = 0;
                        Invoke("ToHitMethod", 2);
                    }
                }
            }
        }
    }
    
    void ToMainMethod()
    {
        SceneManager.LoadScene("Main");
    }

    void ToHitMethod()
    {
        SceneManager.LoadScene("Hit");
    }
}
