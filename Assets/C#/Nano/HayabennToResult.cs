using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HayabennToResult : MonoBehaviour
{
    public float HayabennTime; //Hayabenn�ɗ��Ă���̎���
    public float alertTime;  //�U������O�ɂȂ鎞��
    bool alertCalledOnce = false; //�U�����������񂾂��炷
    public float skipT;

    public AudioClip sound1; //�^�C���A�b�v����
    AudioSource audiosource;

    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>(); //Component�̎擾
        alertTime = Random.Range(2.0f, 8.0f);
        Debug.Log(alertTime);
    }

    // Update is called once per frame
    void Update()
    {
        HayabennTime = HayabennTime + Time.deltaTime;

        if (HayabennTime > alertTime && alertCalledOnce == false)
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
