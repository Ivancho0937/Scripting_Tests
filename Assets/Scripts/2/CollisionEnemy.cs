using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEnemy : MonoBehaviour

{

    public int da�oEnemigo1 = 1;
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

            PlayerController.GetInstance().salud(da�oEnemigo1);
            
        }
    }
}
