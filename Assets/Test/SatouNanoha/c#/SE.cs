using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SE : MonoBehaviour
{
    public GameObject main;
    private Main mainCs;
    private AudioSource hanashikakeru;
    AudioSource audiosource;

    // Start is called before the first frame update
    void Start()
    {
        hanashikakeru = GetComponent<AudioSource>();

        main = GameObject.Find("Main");//�ϐ�main�ɁhMain�h�Ƃ������O�̃I�u�W�F�N�g�������ē����
        mainCs = main.GetComponent<Main>();//�ϐ�mainCs�ɃI�u�W�F�N�gmain�ɂ��Ă���Main�Ƃ����Ƃ����X�N���v�g������

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            hanashikakeru.PlayOneShot(hanashikakeru.clip);
        }

        if (mainCs.eraser >= 2)
        {
            hanashikakeru.Stop();
        }

    }
}
