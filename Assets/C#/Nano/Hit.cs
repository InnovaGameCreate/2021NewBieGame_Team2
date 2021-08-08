using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Hit : MonoBehaviour
{
    private GameObject main;
    private Main mainCs;
    public AudioClip sound1; //������������
    AudioSource audiosource;
    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>(); //Component�̎擾
        audiosource.PlayOneShot(sound1);  //�����S������SE
        main = GameObject.Find("Main");
        mainCs = main.GetComponent<Main>();
        mainCs.eraser = mainCs.eraser - 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))//Space��������
        {
            SceneManager.LoadScene("Main");
        }
    }
}
