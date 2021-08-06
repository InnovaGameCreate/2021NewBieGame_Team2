using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    bool isCountdownStart;
    bool eraserUp = true;
    public Text text;
    public Canvas canvas;
    public Text timerText;
    private float a = 3.0f;
    public float timer;
    public float countdown = 5.0f;
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
        if (mainCs.eraser <= 1)
        {
            if (Input.GetKeyDown(KeyCode.T))
            {
                Debug.Log("a");
                isCountdownStart = true;
            }
        }

        timerText.text = countdown.ToString("f1") + "�b";
        text.enabled = false;

        if (isCountdownStart && countdown > -3.0f)
        {
            countdown = countdown - Time.deltaTime;
        }

        if (countdown > -3 && countdown <= 0)
        {
            if (a >= -5)
            {
                a = a - Time.deltaTime;
            }
            text.enabled = true;
            canvas.enabled = false;
            isCountdownStart = false;
            Debug.Log("���̃^�C�~���O�ŏ����S���̐����J�E���g");
            if (eraserUp == true)
            {
                mainCs.eraser = mainCs.eraser + 1;
                eraserUp = false;
            }
        }

        if (a <= 0)
        {
            text.enabled = false;
            Debug.Log("�u�����S������ɓ��ꂽ�I�v������");
        }

        if (mainCs.eraser >= 2)
        {
            canvas.enabled = false;
        }
    }
}
