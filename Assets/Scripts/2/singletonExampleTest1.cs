using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class singletonExampleTest1 : MonoBehaviour { 

    // Start is called before the first frame update
   
        
   
    public static singletonExampleTest1 instancia;
    void Awake()
    {
        if (instancia == null)
        {
            instancia = this;
        }
        else if (instancia != this)
        {
            Destroy(gameObject);
        }
    }
}