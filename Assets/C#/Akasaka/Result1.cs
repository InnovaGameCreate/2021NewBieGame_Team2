using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result1 : MonoBehaviour
{   
    private int score;
    public GameObject main;
    private Main mainCs;
    public Text Text;    
    // Start is called before the first frame update
    void Start()
    {
        main = GameObject.Find("Main");
        mainCs = main.GetComponent<Main>();
        Text.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
