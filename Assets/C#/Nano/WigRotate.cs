using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WigRotate : MonoBehaviour
{
    private float rotateTime; //10�`20�b�̒l���������
    public float rotate;  //���Ԃ��Ƃɉ��Z
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotateTime = Random.Range(10.0f, 20.0f);    //10�`20�b�̒l����
        if (rotateTime > rotate)
            rotate = rotate + Time.deltaTime;
        if (rotateTime <= rotate)
        {
            transform.Rotate(-180, 0, 0);
            Debug.Log("a");
            rotate = 0;
            Invoke("DelayMethod", 2);  //2�b���DelayMethod��
        }
    }

    void DelayMethod()
    {
        transform.Rotate(new Vector3(180, 0, 0));
    }
}
