using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public Transform personaje;

    
   void Start()
    {
       
    }
   
   void Update() 
    {

        transform.position = new Vector3(personaje.transform.position.x, personaje.transform.position.y, transform.position.z);

    }

   
}
