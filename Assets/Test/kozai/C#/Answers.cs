using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Answers : MonoBehaviour
{
    public Text text;
    public Text Answer;
    public Randommaker Randommaker;
    public InputField inputField;
    
    // Start is called before the first frame update
    void Start()
    {

    }   
        public void SetText(){
            int Z;
        Z = Randommaker.Z;
        inputField = inputField.GetComponent<InputField> ();
        string X = Z.ToString();
        if (inputField.text == X )
        {
            SceneManager.LoadScene("Main");
        }
    } 


    // Update is called once per frame
    void Update()
    {
        
    }
}
