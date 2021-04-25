using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour
{
    public string colorIngresado;

    void evaluador()
    {
        switch (colorIngresado)
        {
            case "amarillo" :
                print("Ahora tienes el poder de la electricidad");
                break;

            case "azul":
                print("Ahora tienes el poder del agua");
                break;


            case "rojo":
                print("Ahora tienes el poder del fuego");
                break;

            case "verde":
                print("Ahora tienes el poder de la tierra");
                break;


            default:
                print("no hay poder asignado");
                break;


        }
    }
   
    void Update()
    {
        evaluador();
    }
}
