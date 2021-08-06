using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result1 : MonoBehaviour
{   
    private int score;
    public GameObject mainmain;
    private mainmain mainmainCs;
    public Text Text;    
    // Start is called before the first frame update
    void Start()
    {
        mainmain = GameObject.Find("mainmain");
        mainmainCs = mainmain.GetComponent<mainmain>();
        Text.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
