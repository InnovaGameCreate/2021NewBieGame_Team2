using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    private GameObject main;
    private Main mainCs;
    public Text score;
    // Start is called before the first frame update
    void Start()
    {
        main = GameObject.Find("Main");
        mainCs = main.GetComponent<Main>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "SCORE : " + mainCs.score.ToString("f1");
    }
}
