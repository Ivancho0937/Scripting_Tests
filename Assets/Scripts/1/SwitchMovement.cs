using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchMovement : MonoBehaviour
{
    public GameObject Cube;
    public string movimiento;
    public float speed = 1.0f;



    

    // Update is called once per frame
    void Update()
    {
        switch(movimiento)
        {
            case "arriba":
                Cube.transform.position = new Vector3(0, 1, 0);
                break;

            case "abajo":
                Cube.transform.position = new Vector3(0, -1, 0);
                break;

            case "derecha":
                Cube.transform.position = new Vector3(1, 0, 0);
                break;

            case "izquierda":
                Cube.transform.position = new Vector3(-1, 0, 0);
                break;

            case "adelante":
                Cube.transform.position = new Vector3(0, 0, 1);
                break;

            case "atras":
                Cube.transform.position = new Vector3(0, 0, -1);
                break;

            default:
                Cube.transform.localPosition = new Vector3(0, 0, 0);
                break;
        }
    }
}
