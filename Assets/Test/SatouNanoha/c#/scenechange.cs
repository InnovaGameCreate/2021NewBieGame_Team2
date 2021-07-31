using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenechange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                SceneManager.LoadScene("Left");
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                SceneManager.LoadScene("Right");
            }
            if (Input.GetKey(KeyCode.Space))
            {
                SceneManager.LoadScene("Inemuri");
            }
            if (Input.GetKey(KeyCode.A))
            {
                SceneManager.LoadScene("Hayabenn");
            }
        }
    }
}
