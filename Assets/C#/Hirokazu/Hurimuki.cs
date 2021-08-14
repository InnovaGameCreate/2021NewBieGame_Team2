using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hurimuki : MonoBehaviour
{
    private float rotateTime; //10`20•b‚Ì’l‚ð‘ã“ü‚³‚ê‚é
    public float rotate;  //ŽžŠÔ‚²‚Æ‚É‰ÁŽZ
    [SerializeField] private Renderer Wig1;
    [SerializeField] private Renderer Wig2;
    // Start is called before the first frame update
    void Start()
    {
        rotateTime = Random.Range(2.0f, 12.0f); 
    }

    // Update is called once per frame
    void Update()
    {
        
        if (rotateTime > rotate)
            rotate = rotate + Time.deltaTime;
        if (rotateTime <= rotate)
        {
            Wig1.enabled = false;
            Wig2.transform.position = Wig1.transform.position;
            Wig2.enabled = true;
            Invoke("HurimukiMethod", 2);
        }
    }

    void HurimukiMethod()
    {
        Wig1.enabled = true;
        Wig1.transform.position = Wig2.transform.position;
        Wig2.enabled = false;
        rotate = 0;
    }
}
