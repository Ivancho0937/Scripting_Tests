using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchInput : MonoBehaviour
{
    
    
    private Renderer rend;

    private void Start()
    {       
         rend = GetComponent<Renderer>();
        
    }
    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.R))
        {
            rend.material.SetColor("_Color", Color.red);
            print("red");
        }
       else if (Input.GetKeyDown(KeyCode.B))
        {
            rend.material.SetColor("_Color", Color.black);
            print("Black");
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            rend.material.SetColor("_Color", Color.white);
            print("White");
        }
    }
}
