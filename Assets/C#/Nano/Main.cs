using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    public float eraser;
    public float score;
    public float time;
    public float pushtime;
    public Text number;
    public Text nageru;

    bool timeStop = false;
    bool Result1CalledOnce = false;
    public static Main Instance   //DontDestroyï°êªñhé~Ç…égóp
    {
        get; private set;
    }

    // Start is called before the first frame update
    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;

        if(SceneManager.GetActiveScene().name != "Starting")
        DontDestroyOnLoad(this.gameObject);
    }

    void Start()
    {
        time = 180.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeStop == false)
        {
            time = time - Time.deltaTime;
        }

        if(time < 0)
        {
            timeStop = true;
        }
        else
        {
            timeStop = false;
        }

        if (SceneManager.GetActiveScene().name != "Result2")//Ç‡ÇµÇ¢ÇÈÉVÅ[ÉìÇ™"Hurimuita"Ç≈Ç‡"Result2"Ç»Ç¢Ç»ÇÁ
        {
            if(SceneManager.GetActiveScene().name != "Hurimuita" )
            {
                if (SceneManager.GetActiveScene().name != "Setumei")
                {
                    if (SceneManager.GetActiveScene().name != "Starting")
                    {
                        if (time <= 0)
                        {
                            if (Result1CalledOnce == false)
                            {
                                SceneManager.LoadScene("Result1");
                                Result1CalledOnce = true;
                            }
                        }
                    }
                        
                }
                    
            }
               
        }

        if(SceneManager.GetActiveScene().name == "Setumei")
        { 
            timeStop = true;
            Result1CalledOnce = false;
        }
    }
}
