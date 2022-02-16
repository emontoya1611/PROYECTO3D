using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField]
    [Range(0,50)]
    [Tooltip("Velocidad de la bala")]
    public float speed;


    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,0, speed*Time.deltaTime);
    }
} 
