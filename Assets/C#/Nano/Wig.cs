using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wig : MonoBehaviour
{
    public Vector2 wigposition;
    // Start is called before the first frame update
    void Start()
    {
        wigposition = transform.position; //Wigの初期リスを設定
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(Mathf.Sin(Time.time) * 3.9f + wigposition.x, wigposition.y);       //（先生の）Wigを左右に動かす
    }
}
