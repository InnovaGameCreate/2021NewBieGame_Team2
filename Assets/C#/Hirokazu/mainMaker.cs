using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainMaker : MonoBehaviour
{
    public GameObject Main;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Main.gameObject, this.transform.position, this.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
