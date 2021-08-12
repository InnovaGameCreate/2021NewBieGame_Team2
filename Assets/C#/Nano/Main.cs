using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    public float eraser;
    public float score;
    public float time;
    public Text number;
    public Text nageru;

    bool Result1CalledOnce = false;
    public static Main Instance   //DontDestroy�����h�~�Ɏg�p
    {
        get; private set;
    }

    // Start is called before the first frame update
    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;

        DontDestroyOnLoad(this.gameObject);
    }
    void Start()
    {
        time = 180.0f;
    }

    // Update is called once per frame
    void Update()
    {
        time = time - Time.deltaTime;
        if (SceneManager.GetActiveScene().name != "Hurimuita" || SceneManager.GetActiveScene().name != "Result2")//��������V�[����"Hurimuita"�ł�"Result2"�ł�"Result1"�Ȃ��Ȃ�
        {
            if (time <= 0 )
            {
                if (Result1CalledOnce == false)
                {
                    SceneManager.LoadScene("Result1");
                    Result1CalledOnce = true;
                }
            }
        }
    }
}
