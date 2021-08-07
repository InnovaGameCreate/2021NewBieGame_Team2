using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeftToResult : MonoBehaviour
{
    public float LeftTime;//Left‚É—ˆ‚Ä‚©‚ç‚ÌŠÔ
    public float backTime; //U‚èŒü‚­ŠÔ
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
