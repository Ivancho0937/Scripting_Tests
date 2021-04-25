using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dictionary : MonoBehaviour
{


    public Dictionary<string, float> nombrePuntajes = new Dictionary<string, float> { { "Pablo", 1598f }, 
        { "Marlon", 2500f} , { "Juan", 3200f }, { "Oscar", 1000f } };
   
    void Start()
    {
      foreach (KeyValuePair<string, float> element in nombrePuntajes)
        {
            print(element);
            
        }

        print("=====================================");
        nombrePuntajes.Remove("Pablo");


        foreach (KeyValuePair<string, float> element in nombrePuntajes)
        {
            print(element);
        }

        print("=====================================");

        nombrePuntajes["Marlon"] = 6800f;

        
        foreach (KeyValuePair<string, float> element in nombrePuntajes)
        {
            print(element);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
