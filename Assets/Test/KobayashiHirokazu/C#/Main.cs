using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    public float eraser;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (eraser >= 1)        //eraser��1�ȏ�Ȃ�
        {
            if (Input.GetKey(KeyCode.G)) //G�L�[�������ꂽ�Ȃ�
                SceneManager.LoadScene("Shooting");
        }
    }
}
