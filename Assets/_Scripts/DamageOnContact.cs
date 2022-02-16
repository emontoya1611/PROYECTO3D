using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnContact : MonoBehaviour
{
    public float damage;    
    private void OnTriggerEnter(Collider other)
    {
        // Debug.Log(other.name); como ver los nombres de los objetos que colisiona la bala
        gameObject.SetActive(false);  // Desactiva la bala
        /*if (other.CompareTag("enemy") || other.CompareTag("player")) // le hago elegir que si pasa cualqueira de los dos destruyo al objeto
        {
            Destroy(other.gameObject);  // Destruyo el otro objeto (Solo player o enemigo)
        }*/

        Life life = other.GetComponent<Life>();

        if (life != null)
        {
            life.Ammount -= damage;
        } 
        
    }

}
 