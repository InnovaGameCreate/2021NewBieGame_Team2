using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chimeSE : MonoBehaviour
{
    public AudioClip sound; //�^�C���A�b�v����
    AudioSource audiosource;
    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>(); //Component�̎擾
        audiosource.PlayOneShot(sound);  //���Ԑ؂��SE
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
