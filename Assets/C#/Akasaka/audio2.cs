using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio2 : MonoBehaviour
{   
    public AudioClip sound2;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
           audioSource.PlayOneShot(sound2);
        }
    }
}
