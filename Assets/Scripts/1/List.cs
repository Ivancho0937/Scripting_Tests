using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List : MonoBehaviour
{
    public List<float> maximosPuntajes = new List<float>();

    void Start()
    {
        maximosPuntajes.Add(1532f);
        maximosPuntajes.Add(2582f);
        maximosPuntajes.Add(3100f);
        maximosPuntajes.Add(1200f);
        maximosPuntajes.Add(500f);
        maximosPuntajes.Sort();
        maximosPuntajes.Reverse();
        print(maximosPuntajes[0]);


       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
