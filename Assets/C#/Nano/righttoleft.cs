using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class righttoleft : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.LeftArrow))
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
