using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeftToResult : MonoBehaviour
{
    public float LeftTime;//Left�ɗ��Ă���̎���
    public float alertTime; //�U���������
    bool alertCalledOnce = false; //�U�����������񂾂��炷
    public float skipT;

    public AudioClip sound1; //�^�C���A�b�v����
    AudioSource audiosource;

    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>(); //Component�̎擾
        alertTime = Random.Range(4.0f, 15.0f);
        Debug.Log(alertTime);
    }

    // Update is called once per frame
    void Update()
    {
        LeftTime = LeftTime + Time.deltaTime;
        
        if (LeftTime > alertTime && alertCalledOnce == false)
        {
            audiosource.PlayOneShot(sound1); //�x������炷
            alertCalledOnce = true;
            Invoke("ToHurimuitaMethod",skipT); //�x����2�b��Hurimuita��
          }
    }

    void ToHurimuitaMethod()
    {
        SceneManager.LoadScene("Hurimuita");
    }
}
