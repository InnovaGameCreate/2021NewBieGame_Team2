using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShootingToResult : MonoBehaviour
{
    public float ShootingTime; //Shooting�ɗ��Ă���̎���
    public float alertTime;  //�U���������
    bool alertCalledOnce = false; //�U�����������񂾂��炷

    public AudioClip sound1; //�^�C���A�b�v����
    AudioSource audiosource;

    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>(); //Component�̎擾
    }

    // Update is called once per frame
    void Update()
    {
        ShootingTime = ShootingTime + Time.deltaTime;
        alertTime = Random.Range(5.0f, 15.0f);
        if (ShootingTime > alertTime && alertCalledOnce == false)
        {
            audiosource.PlayOneShot(sound1); //�x������炷
            alertCalledOnce = true;
            Invoke("ToHurimuitaMethod", 2); //�x����2�b��Hurimuita��
        }
    }
    
    void ToHurimuitaMethod()
    {
        SceneManager.LoadScene("Hurimuita");
    }
}
