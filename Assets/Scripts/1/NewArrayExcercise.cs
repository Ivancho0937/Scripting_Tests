using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewArrayExcercise : MonoBehaviour
{

    public float[] notas1 = new float[] { 4.5f, 3.9f, 2.5f, 3.5f };
    public float[] notas2 = new float[4];
    private float promedio;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < notas1.Length; i++){ 
        print("Las primeras notas son: " + notas1[i]);
            promedio = promedio + notas1[i];
            
        }

        notas2[0] = 3.5f;
        notas2[1] = 4.0f;
        notas2[2] = 5.0f;
        notas2[3] = 2.5f;

        for (int i = 0; i < notas2.Length; i++)
        {
            print("Las segundas notas son: " + notas2[i]);
            promedio = promedio + notas2[i];
            
        }


        print("el promedio es: " + promedio / (notas1.Length + notas2.Length));


      
    }

    
}
