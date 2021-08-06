using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShootingToResult : MonoBehaviour
{
    public float ShootingTime; //Shootingに来てからの時間
    public float backTime;  //振り向く時間
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
