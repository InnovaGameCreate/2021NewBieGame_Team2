using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class renda : MonoBehaviour
{
    int count = 0;
    // Start is called before the first frame update
    void Start()
    {      
       
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
         SceneManager.LoadScene("Main");
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("Main");
        }
    }
}
