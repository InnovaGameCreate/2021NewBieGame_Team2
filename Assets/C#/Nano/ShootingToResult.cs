using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShootingToResult : MonoBehaviour
{
    public float ShootingTime; //Shooting‚É—ˆ‚Ä‚©‚ç‚ÌŠÔ
    public float backTime;  //U‚èŒü‚­ŠÔ
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ShootingTime = ShootingTime + Time.deltaTime;
        backTime = Random.Range(5.0f, 15.0f);
        if (ShootingTime > backTime)
        {
            SceneManager.LoadScene("Hurimuita");
        }
    }
}
