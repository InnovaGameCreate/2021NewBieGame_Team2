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
        if (eraser >= 1)        //eraser‚ª1ˆÈã‚È‚ç
        {
            if (Input.GetKey(KeyCode.G)) //GƒL[‚ª‰Ÿ‚³‚ê‚½‚È‚ç
                SceneManager.LoadScene("Shooting");
        }
    }
}
