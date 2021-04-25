using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrays : MonoBehaviour
{
    //public string[] poderesPorColor = new string[4];

   // public string[] poderesPorColor = new string[] { "agua", "tierra", "electricidad", "fuego"};

    public string[,] habilidadesEnemigo = { { "verde", "tierra" }, { "azul", "agua" }, { "rojo", "fuego" }, { "amarillo", "electricidad" } };
 

    void Start()
    {

        print(habilidadesEnemigo[2,1]);
       /* print(poderesPorColor[2]);
        poderesPorColor[2] = "magnetismo";
        print(poderesPorColor[2]);
       */
    }

    
    void Update()
    {
        
    }
}
