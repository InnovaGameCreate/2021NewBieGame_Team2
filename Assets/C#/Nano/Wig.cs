using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wig : MonoBehaviour
{
    public Vector2 wigposition;
    // Start is called before the first frame update
    void Start()
    {
        wigposition = transform.position; //Wig�̏������X��ݒ�
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(Mathf.Sin(Time.time) * 5.0f + wigposition.x, wigposition.y);       //�i�搶�́jWig�����E�ɓ�����
    }
}
