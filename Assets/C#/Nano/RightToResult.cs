using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RightToResult : MonoBehaviour
{
    public float RightTime; //Right‚É—ˆ‚Ä‚©‚ç‚ÌŠÔ
    public float alertTime;  //U‚èŒü‚­ŠÔ
    bool alertCalledOnce = false; //U‚èŒü‚«‰¹‚ğˆê‰ñ‚¾‚¯–Â‚ç‚·

    public AudioClip sound1; //ƒ^ƒCƒ€ƒAƒbƒv‰¹Œ¹
    AudioSource audiosource;

    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>(); //Component‚Ìæ“¾
        alertTime = Random.Range(4.0f, 15.0f);
        Debug.Log(alertTime);
    }

    // Update is called once per frame
    void Update()
    {
        RightTime = RightTime + Time.deltaTime;
       
        if (RightTime > alertTime && alertCalledOnce == false)
        {
            audiosource.PlayOneShot(sound1); //Œx‰¹‚ğ–Â‚ç‚·
            alertCalledOnce = true;
            Invoke("ToHurimuitaMethod", 2); //Œx‚Ì2•bŒãHurimuita‚Ö
        }
    }

    void ToHurimuitaMethod()
    {
        SceneManager.LoadScene("Hurimuita");
    }
}
