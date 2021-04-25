using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyforScript : MonoBehaviour
{
    public int controlNumero = 5;

    void Start()
    {
        for (int i = 0; i < controlNumero; i++)
        {
            Debug.Log(i);
        }



    }

}
