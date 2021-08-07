using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
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
        if (mainCs.eraser >= 1)        //eraserÇ™1à»è„Ç»ÇÁ
        {
            if (Input.GetKey(KeyCode.G)) //GÉLÅ[Ç™âüÇ≥ÇÍÇΩÇ»ÇÁ
                SceneManager.LoadScene("Shooting");
        }

        if (Input.GetKey(KeyCode.RightArrow))
            SceneManager.LoadScene("Right");

        if (Input.GetKey(KeyCode.LeftArrow))
            SceneManager.LoadScene("Left");

        if (Input.GetKey(KeyCode.A))
            SceneManager.LoadScene("Hayabenn");

        if (Input.GetKey(KeyCode.Space))
            SceneManager.LoadScene("Inemuri");
    }
}
