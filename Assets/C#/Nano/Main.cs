using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    public float eraser;
    public float score;
    public float time = 180.0f;
    public Text number;
    public Text nageru;
    bool timeLimit = true; //�v���C���Ԃ̐���

    public AudioClip sound1; //�^�C���A�b�v����
    AudioSource audiosource;

    public static Main Instance
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
        audiosource = GetComponent<AudioSource>(); //Component�̎擾
    }

    // Update is called once per frame
    void Update()
    {
        time = time - Time.deltaTime;
        if (SceneManager.GetActiveScene().name != "Hurimuita" || SceneManager.GetActiveScene().name != "Result2")//��������V�[����"Hurimuita"�ł�"Result2"�ł��Ȃ��Ȃ�
        {
            if (time >= 180)
            {
                audiosource.PlayOneShot(sound1);  //���Ԑ؂��SE
                Invoke("DelayMethod", 2);  //2�b���DelayMethod��
            }
        }
    }
    void DelayMethod()
    {
        if (timeLimit == true)
        {
            SceneManager.LoadScene("Result1");
            timeLimit = false;
        }
    }
}
