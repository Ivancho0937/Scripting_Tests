using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class family : MonoBehaviour
{
    public myinstantiablescript father;
    public myinstantiablescript mother;
    public myinstantiablescript son;

    void Start()
    {
        father = new myinstantiablescript();
        father.name = "juan gabriel";
        father.lastname = "Rodriguez";
        father.secondLastName = "Salas";
        father.age = 28;
        father.isMarried = true;


        mother = new myinstantiablescript();
        mother.name = "Maria";
        mother.lastname = "Perez";
        mother.secondLastName = "Cardona";
        mother.age = 28;
        mother.isMarried = true;
        mother.isFather = false;


        father.spouse = mother;
        mother.spouse = father;

        if (father.isMarriedTo(mother))
        {
            print(father.name + " is married to " + mother.name);
        }
        else
        {
            print(father.name + " is not married to " + mother.name);

        }
            
        son = new myinstantiablescript();
        son.name = "Roberto";
        son.lastname = father.lastname;
        son.secondLastName = mother.lastname;
        son.age = 10;
        son.isMarried = false;
        son.isFather = false;


        print(father.name + " and " + mother.name +" has a son called " + son.name + " who's "
            + son.age + " years old");

        }


          

}



