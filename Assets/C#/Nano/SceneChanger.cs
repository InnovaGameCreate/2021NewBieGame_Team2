using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    bool nagaoshi = false;
    public GameObject main;
    private Main mainCs;

    // Start is called before the first frame update
    void Start()
    {
            main = GameObject.Find("Main");
            mainCs = main.GetComponent<Main>();
    }

    // Update is called once per frame
    void Update()
    {
        if (mainCs.eraser >= 1)        //eraser‚ª1ˆÈã‚È‚ç
        {
            if (Input.GetKey(KeyCode.G)) //GƒL[‚ª‰Ÿ‚³‚ê‚½‚È‚ç
                SceneManager.LoadScene("Shooting");
        }

        if (Input.GetKey(KeyCode.RightArrow))
            SceneManager.LoadScene("Right");

        if (Input.GetKey(KeyCode.LeftArrow))
            SceneManager.LoadScene("Left");

        if (Input.GetKey(KeyCode.A))
            SceneManager.LoadScene("Hayabenn");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            nagaoshi = true;
            mainCs.pushtime = 0;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            nagaoshi = false;
            mainCs.pushtime = 0;
        }

        if (nagaoshi == true)
        {
            mainCs.pushtime = mainCs.pushtime + Time.deltaTime;

            if (mainCs.pushtime >= 1)
            {
                if (Input.GetKey(KeyCode.Space))
                {
                    nagaoshi = false;
                    mainCs.pushtime = 0;
                    SceneManager.LoadScene("Inemuri");
                }
            }
        }
    }
}
