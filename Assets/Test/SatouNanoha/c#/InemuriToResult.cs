using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InemuriToResult : MonoBehaviour
{
    public float InemuriTime; //Inemuri�ɗ��Ă���̎���
    public float backTime;  //�U���������
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InemuriTime = InemuriTime + Time.deltaTime;
        backTime = Random.Range(5.0f, 15.0f);
        if (InemuriTime > backTime)
        {
            SceneManager.LoadScene("Hurimuita");
        }
    }
}
