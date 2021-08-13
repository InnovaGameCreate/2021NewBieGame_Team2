using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class allSE : MonoBehaviour
{
    public AudioClip sound1;
    public AudioClip sound2;
    AudioSource audioSource;

    public static allSE Instance   //DontDestroy�����h�~�Ɏg�p
    {
        get; private set;
    }

    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    { 
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Setumei")
        {
            if (Input.GetKey(KeyCode.Return))
            {
                audioSource.PlayOneShot(sound2);
                SceneManager.LoadScene("Main");
            }
        }
        if (SceneManager.GetActiveScene().name == "Left")
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                audioSource.PlayOneShot(sound1);
                SceneManager.LoadScene("Main");
            }
        }
        if (SceneManager.GetActiveScene().name == "Right")
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                audioSource.PlayOneShot(sound1);
                SceneManager.LoadScene("Main");
            }
        }
        if (SceneManager.GetActiveScene().name == "Inemuri")
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                audioSource.PlayOneShot(sound1);
                SceneManager.LoadScene("Main");
            }
        }
        if (SceneManager.GetActiveScene().name == "hayabenn" || SceneManager.GetActiveScene().name == "Shooting")
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                audioSource.PlayOneShot(sound1);
                SceneManager.LoadScene("Main");
            }
        }
        if (SceneManager.GetActiveScene().name == "Main")
        {
            if (Input.GetKey(KeyCode.I))
            {
                SceneManager.LoadScene("Help");
            }
        }
        if (SceneManager.GetActiveScene().name == "Help")
        {
            if (Input.GetKey(KeyCode.I))
            {
                SceneManager.LoadScene("Main");
            }
        }


    }
}
