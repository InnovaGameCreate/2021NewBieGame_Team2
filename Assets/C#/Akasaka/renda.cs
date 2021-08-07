using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class renda : MonoBehaviour
{
    float count = 0;
    public int point;
    public float score;
    private GameObject main;
    private Main mainCs;
    public Image Image1;
    public Sprite Sprite1;
    // Start is called before the first frame update
    void Start()
    {
        main = GameObject.Find("Main");
        mainCs = main.GetComponent<Main>();
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.F))
        {
            count += 1;
        }
        if (count >= 20)
        {
        Image1.sprite = Sprite1;
        Invoke("DelayMethod", 3.5f);
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("Main");
        }
    }
    void DelayMethod()
    {
        mainCs.score = mainCs.score + point; 
        SceneManager.LoadScene("Main");
    }
}
