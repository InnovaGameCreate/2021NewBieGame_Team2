using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hurimuita : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("DelayMethod", 1);  //1•bŒã‚ÉDelayMethod‚Ö
    }

    void DelayMethod()
    {
        SceneManager.LoadScene("Result2");
    }
}
