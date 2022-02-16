using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour
{

public float sumaVida;

    private void OnTriggerEnter(Collider other) {
        Life life = other.GetComponent<Life>();
        
        if ( life.Ammount >= 0)
        {
            life.Ammount += sumaVida;
        }

        Destroy(gameObject);
    } 
}
