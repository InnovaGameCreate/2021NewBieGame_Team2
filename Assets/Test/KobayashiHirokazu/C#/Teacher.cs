using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Teacher : MonoBehaviour
{
    public Vector2 wigposition;

    // Start is called before the first frame update
    void Start()
    {
        wigposition = transform.position;
    }
    

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(Mathf.Sin(Time.time) * 5.0f + wigposition.x, wigposition.y);       //ÅiêÊê∂ÇÃÅjWigÇç∂âEÇ…ìÆÇ©Ç∑
    }
}
