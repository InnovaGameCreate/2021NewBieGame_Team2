using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HayabennToResult : MonoBehaviour
{
    public float HayabennTime; //Hayabenn�ɗ��Ă���̎���
    public float backTime;  //�U���������
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HayabennTime = HayabennTime + Time.deltaTime;
        backTime = Random.Range(5.0f, 15.0f);
        if (HayabennTime > backTime)
        {
            SceneManager.LoadScene("Hurimuita");
        }
    }
}
