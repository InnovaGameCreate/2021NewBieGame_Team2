using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeController : MonoBehaviour
{
    public GameObject main;
    private Main mainCs;
    float red, green, blue, alfa;
    Image fadeImage;//透明度を変更するPanelのイメージ

    // Start is called before the first frame update
    void Start()
    {
        main = GameObject.Find("Main");
        mainCs = main.GetComponent<Main>();
        fadeImage = GetComponent<Image>();
        red = fadeImage.color.r;
        green = fadeImage.color.g;
        blue = fadeImage.color.b;
        alfa = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(alfa);
        alfa = mainCs.pushtime * 255 * 0.002f;
        fadeImage.color = new Color(red, green, blue, alfa);
    }
}
