using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class audiodesu : MonoBehaviour
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
        if (Input.GetKeyDown (KeyCode.F))
        {
            audioSource.PlayOneShot(sound1);
        }
    }
}
