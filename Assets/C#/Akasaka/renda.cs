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
    public AudioClip sound2;
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
            if (scoreonce == true)
            {
            Image1.sprite = Sprite1;
            audioSource.PlayOneShot(sound2);
            mainCs.score = mainCs.score + point;
            scoreonce = false;
            Invoke("DelayMethod", 1f);
            }
        }
    }
    void DelayMethod()
    {   
        SceneManager.LoadScene("Main");    
    }
}
