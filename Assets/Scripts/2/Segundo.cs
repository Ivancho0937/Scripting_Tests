using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Segundo : MonoBehaviour
{
    public Familia father;


    void Start()
    {
        father = new Familia();
        father.nombre = "Roberto";
        father.Apellido = "Perez";


        print("el nombre del personaje es: " + father.nombre + father.Apellido);
    }

    
}
