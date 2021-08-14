using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hurimuki : MonoBehaviour
{
    private float rotateTime; //10〜20秒の値を代入される
    public float rotate;  //時間ごとに加算
    [SerializeField] private Renderer Wig;
    [SerializeField] private Renderer Wig2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotateTime = Random.Range(4.0f, 20.0f);    //4〜20秒の値を代入
        if (rotateTime > rotate)
            rotate = rotate + Time.deltaTime;
        if (rotateTime <= rotate)
        {
            Wig.enabled = false;
            Wig2.transform.position = Wig.transform.position;
            Wig2.enabled = true;
            Invoke("HurimukiMethod", 2);
        }
    }

    void HurimukiMethod()
    {
        Wig.enabled = true;
        Wig.transform.position = Wig2.transform.position;
        Wig2.enabled = false;
        rotate = 0;
    }
}
