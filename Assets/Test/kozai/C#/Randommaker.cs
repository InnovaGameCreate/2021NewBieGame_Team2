using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Randommaker : MonoBehaviour
{
    public InputField inputField;
    public Text text;
    public Text Answer;
    public int Z;
    // Start is called before the first frame update
    void Start()
    {
        inputField = inputField.GetComponent<InputField> ();
        text = text.GetComponent<Text> ();
        Answer = text.GetComponent<Text> ();
        int A = (Random.Range (10000,99999));
        Z = A;
        string X = A.ToString();
        text.text = X;
    }

    // Update is called once per frame
    void Update()
    {
                if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("Main");
        }       

    }
}
