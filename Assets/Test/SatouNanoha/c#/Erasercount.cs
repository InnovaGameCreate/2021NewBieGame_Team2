using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Erasercount : MonoBehaviour
{
    public GameObject main;
    private Main mainCs;
    public Text erasercount;

    // Start is called before the first frame update
    void Start()
    {
        main = GameObject.Find("Main");//�ϐ�main�ɁhMain�h�Ƃ������O�̃I�u�W�F�N�g�������ē����
        mainCs = main.GetComponent<Main>();//�ϐ�mainCs�ɃI�u�W�F�N�gmain�ɂ��Ă���Main�Ƃ����Ƃ����X�N���v�g������
    }

    // Update is called once per frame
    void Update()
    {
        erasercount.text = mainCs.eraser.ToString() + "��";
    }
}
