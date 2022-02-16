using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{

    [SerializeField]
    private float ammount;

    public float Ammount
    {
        get => ammount;
        set
        {
            ammount = value;

            if (ammount <= 0)
            {
                ParticleSystem explosion = GetComponentInChildren<ParticleSystem>();
                explosion.Play();

                Animator anim = GetComponent<Animator>();
                anim.SetTrigger("Die");

                Destroy(gameObject, 2);
            }
        } 
    }

    
}
    