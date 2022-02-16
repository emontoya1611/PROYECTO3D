 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moverse : MonoBehaviour
{
    [SerializeField]
    [Range(0, 14)]
    [Tooltip("Velocidad de Movimiento del Personaje en m/s")]
    public float speed = 0;
    [SerializeField]
    [Range(0, 360)]
    [Tooltip("Velocidad de Rotación del Personaje en °")]
    public float rotationSpeed = 0;
    public Animator animator; 
    // Update is called once per frame
   
    void Update()
    {
        float space = speed * Time.deltaTime;
        float horizontal = Input.GetAxis("Horizontal") ;  // -1 a 1
        float vertical = Input.GetAxis("Vertical"); // -1 a 1

        Vector3 dir = new Vector3(horizontal,0,vertical);
        transform.Translate(dir.normalized * space);

        float angle = rotationSpeed * Time.deltaTime;
        float mouseX = Input.GetAxis("Mouse X");
        this.transform.Rotate(0,mouseX * angle ,0);

        animator.SetFloat("MoveX", horizontal); 
        animator.SetFloat("MoveY", vertical);
    }
}
 