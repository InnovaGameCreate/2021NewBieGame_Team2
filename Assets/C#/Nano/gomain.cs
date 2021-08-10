using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gomain : MonoBehaviour
{
    public AudioClip sound1;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            audioSource.PlayOneShot(sound1);
            Invoke("ToMainMethod", 1.0f);
        }
    }
    void ToMainMethod()
    {
        SceneManager.LoadScene("Main");
    }
}
