using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RightToResult : MonoBehaviour
{
    public float RightTime; //Right�ɗ��Ă���̎���
    public float backTime;  //�U���������
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RightTime = RightTime + Time.deltaTime;
        backTime = Random.Range(5.0f, 15.0f);
        if (RightTime > backTime)
        {
            SceneManager.LoadScene("Hurimuita");
        }
    }
}
