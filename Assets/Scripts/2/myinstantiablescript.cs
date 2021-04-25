using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myinstantiablescript 
{
    public string name = "";
    public string lastname = "";
    public string secondLastName = "";
    public int age = 0;
    public string adress = "";
    public bool isMarried = false;
    public bool isFather = true;
    public myinstantiablescript spouse;


    public bool isMarriedTo(myinstantiablescript spouse)
    {
        return this.spouse == spouse;
    }


}
