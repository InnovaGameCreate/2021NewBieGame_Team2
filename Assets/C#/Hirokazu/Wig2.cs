using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wig2 : MonoBehaviour
{
    public GameObject Wig;
    public float lifeTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lifeTime = lifeTime + Time.deltaTime;
        if (lifeTime >= 2)
        {
            Destroy(this.gameObject);
            Instantiate(Wig.gameObject, this.transform.position, this.transform.rotation);
        }
    }
}
