using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InemuriToMain : MonoBehaviour
{
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
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("�X�R�A���J�E���g");
            mainCs.score = mainCs.score + 0.1f;
        }
    }
}
