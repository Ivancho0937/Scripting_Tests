using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEnemy : MonoBehaviour

{

    public int dañoEnemigo1 = 1;
    /*private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PlayerController.GetInstance().KillPlayer();
                print("Juagdor tocado");
        }
    }
    */

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
           // Debug.Log("enemigo tocado");
            //PlayerController.GetInstance().KillPlayer();

            PlayerController.GetInstance().salud(dañoEnemigo1);
            
        }
    }
}
