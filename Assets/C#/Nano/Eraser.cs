using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Eraser : MonoBehaviour
{
    public Text nageru;
    public GameObject main;
    private Main mainCs;

    // Start is called before the first frame update
    void Start()
    {
        main = GameObject.Find("Main");//�ϐ�main�ɁhMain�h�Ƃ������O�̃I�u�W�F�N�g�������ē����
        mainCs = main.GetComponent<Main>();//�ϐ�mainCs�ɃI�u�W�F�N�gmain�ɂ��Ă���Main�Ƃ����Ƃ����X�N���v�g������
    }

    // Update is called once per frame
    void Update()
    {
        Text nageru = this.GetComponent<Text>();// Text�R���|�[�l���g���擾
        nageru.color = new Color(0.5f, 0.5f, 0.5f, 1.0f); // �F���w��

        if (mainCs.eraser >= 1)
        {
            nageru.color = new Color(0.0f, 0.0f, 0.0f, 1.0f); // �F���w��
        }
    }
}
