using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Target : MonoBehaviour
{
    public float score;
    public float eraser; //�I�I�I�IMain��eraser�Ƃ̃����N
    public float xRange;
    public float reloadTime;
    private float reload;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)) //�E�L�[�������ꂽ�Ȃ�
        {
            if (this.transform.position.x <= xRange)
                transform.Translate(new Vector2(10, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))     //���L�[�������ꂽ�Ȃ�
        {
            if (this.transform.position.x >= xRange * -1)
                transform.Translate(new Vector2(-10, 0) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.Escape))   //Escape�������ꂽ��"Main"�ɖ߂�
            SceneManager.LoadScene("Main");

        if (eraser <= 0)      //eraser��0�ɂȂ�����"Main"�ɖ߂�
            SceneManager.LoadScene("Main");

        if (reloadTime > reload)
            reload = reload + Time.deltaTime;
        else
           if (Input.GetKeyDown(KeyCode.G))
        {
            eraser = eraser - 1; //�����S������
            reload = 0;
        }
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "teacher")
        {
            if (reloadTime > reload)
                reload = reload + Time.deltaTime;
            else
            {
                if (Input.GetKeyDown(KeyCode.G))
                {
                    score = score + 1; Debug.Log("��������");//�X�R�A���Z
                    SceneManager.LoadScene("Hit");
                    reload = 0;
                }
            }
        }
    }
}
