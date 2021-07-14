using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            SceneManager.LoadScene("left");
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            SceneManager.LoadScene("right");
        }
        if(Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("inemuri");
        }
        if (Input.GetKey(KeyCode.A))
        {
            SceneManager.LoadScene("hayabenn");
        }
    }
}
