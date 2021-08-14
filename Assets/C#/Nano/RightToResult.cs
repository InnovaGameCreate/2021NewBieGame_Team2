using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RightToResult : MonoBehaviour
{
    public float RightTime; //Right�ɗ��Ă���̎���
    public float alertTime;  //�U���������
    bool alertCalledOnce = false; //�U�����������񂾂��炷
    public float skipT;

    public AudioClip sound1; //�^�C���A�b�v����
    AudioSource audiosource;

    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>(); //Component�̎擾
        alertTime = Random.Range(3.0f, 10.0f);
        Debug.Log(alertTime);
    }

    // Update is called once per frame
    void Update()
    {
        RightTime = RightTime + Time.deltaTime;
       
        if (RightTime > alertTime && alertCalledOnce == false)
        {
            audiosource.PlayOneShot(sound1); //�x������炷
            alertCalledOnce = true;
            Invoke("ToHurimuitaMethod", skipT); //�x����2�b��Hurimuita��
        }
    }

    void ToHurimuitaMethod()
    {
        SceneManager.LoadScene("Hurimuita");
    }
}
