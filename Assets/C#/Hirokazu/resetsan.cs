using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetsan : MonoBehaviour
{
    public GameObject main;
    private Main mainCs; //������Main�̓X�N���v�g���H

   
    // Start is called before the first frame update
    void Start()
    {
        main = GameObject.Find("Main");//�ϐ�main�ɁhMain�h�Ƃ������O�̃I�u�W�F�N�g�������ē����
        mainCs = main.GetComponent<Main>();//�ϐ�mainCs�ɃI�u�W�F�N�gmain�ɂ��Ă���Main�Ƃ����Ƃ����X�N���v�g������


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            mainCs.time = 180.0f;
            mainCs.eraser = 0;
            mainCs.score = 0;
           



        }
    }
}