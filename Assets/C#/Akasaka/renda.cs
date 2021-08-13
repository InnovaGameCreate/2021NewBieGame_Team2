using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class renda : MonoBehaviour
{
    bool haoto = true;
    float count = 0;
    public int point;
    public float score;
    private GameObject main;
    private Main mainCs;
    public Image Image1;
    public Sprite Sprite1;
    public AudioClip sound1;
    AudioSource audioSource;
    bool scoreonce = true;
    // Start is called before the first frame update
    void Start()
    {
        main = GameObject.Find("Main");
        mainCs = main.GetComponent<Main>();
        audioSource = GetComponent<AudioSource>();
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
            Image1.sprite = Sprite1;
            Invoke("DelayMethod", 1f);

            if (haoto == true)
            {
                audioSource.PlayOneShot(sound1);
                haoto = false;
            }
        }
    }
    void DelayMethod()
    {   if (scoreonce == true)
        {
        mainCs.score = mainCs.score + point; 
        SceneManager.LoadScene("Main");
        scoreonce = false;
        }
    }
}
