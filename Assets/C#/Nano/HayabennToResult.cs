using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HayabennToResult : MonoBehaviour
{
    public float HayabennTime; //Hayabenn‚É—ˆ‚Ä‚©‚ç‚ÌŠÔ
    public float alertTime;  //U‚èŒü‚­‘O‚É‚È‚éŠÔ
    bool alertCalledOnce = false; //U‚èŒü‚«‰¹‚ğˆê‰ñ‚¾‚¯–Â‚ç‚·
    public float skipT;

    public AudioClip sound1; //ƒ^ƒCƒ€ƒAƒbƒv‰¹Œ¹
    AudioSource audiosource;

    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>(); //Component‚Ìæ“¾
        alertTime = Random.Range(2.0f, 8.0f);
        Debug.Log(alertTime);
    }

    // Update is called once per frame
    void Update()
    {
        HayabennTime = HayabennTime + Time.deltaTime;

        if (HayabennTime > alertTime && alertCalledOnce == false)
        {
            audiosource.PlayOneShot(sound1); //Œx‰¹‚ğ–Â‚ç‚·
            alertCalledOnce = true; 
            Invoke("ToHurimuitaMethod", skipT); //Œx‚Ì2•bŒãHurimuita‚Ö
        }
    }

    void ToHurimuitaMethod()
    {
        SceneManager.LoadScene("Hurimuita");
    }
}
