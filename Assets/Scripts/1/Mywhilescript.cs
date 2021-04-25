using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mywhilescript : MonoBehaviour
{
    public int numeroControl = 0;
    

    void Start()
    {
        while (numeroControl < 5)
        {
            Debug.Log(numeroControl);
            numeroControl++;
        }
    }


    
}
