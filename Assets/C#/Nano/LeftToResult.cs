using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeftToResult : MonoBehaviour
{
    public float LeftTime;//Left�ɗ��Ă���̎���
    public float backTime; //�U���������
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LeftTime = LeftTime + Time.deltaTime;
        backTime = Random.Range(8.0f, 15.0f);
        if (LeftTime > backTime)
        {
            SceneManager.LoadScene("Hurimuita");
        }
    }
}
