using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class audiodesu : MonoBehaviour
{
    public AudioClip sound1;
    AudioSource audioSource;
    float are = 0;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (are <= 20)
        {
        if (Input.GetKeyDown (KeyCode.F))
        {
            are += 1;
            audioSource.PlayOneShot(sound1);
        }
        }
    }
}
