using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timecount : MonoBehaviour
{
    public GameObject main;
    private Main mainCs;
    public Text timeText;

    // Start is called before the first frame update
    void Start()
    {
        main = GameObject.Find("Main");
        mainCs = main.GetComponent<Main>();
    }

    // Update is called once per frame
    void Update()
    {
        timeText.text = "Žc‚èŽžŠÔ:" + mainCs.time.ToString("f1");
    }
}
