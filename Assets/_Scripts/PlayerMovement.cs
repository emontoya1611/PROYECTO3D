using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Fuerza de Movimiento del Personaje en m/s")]
    public float speed;
    
    [SerializeField]
    [Tooltip("Fuerza de Rotación del Personaje en °")]
    public float rotationSpeed = 0;
    private Rigidbody rb;
    public Animator animator; 

    public bool enPiso;
    public float fuerzaSalto;
    public Transform refPie;

    void Start() 
    {
        Cursor.visible = true; 
        Cursor.lockState = CursorLockMode.Locked;

        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    void Update() {
        Move();
    }
    
    void Move()
    {
        float space = speed * Time.deltaTime;
        float horizontal = Input.GetAxis("Horizontal") ;  // -1 a 1
        float vertical = Input.GetAxis("Vertical"); // -1 a 1

        Vector3 dir = new Vector3(horizontal,0,vertical);
        //transform.Translate(dir.normalized * space);  // MOVER EL PERSONAJE EN HORIZONTAL Y VERTICAL POR TRANSLATE
        // FUERZA DE TRANSLACIÓN
        rb.AddRelativeForce(dir.normalized * (space * 400));

        float angle = rotationSpeed * Time.deltaTime;
        float mouseX = Input.GetAxis("Mouse X");
        // transform.Rotate(0,mouseX * angle ,0); // ROTA LA PANTALLA CON EL MOUSE POR ROTACIÓN DE LA CAMARA
        // FUERZA DE ROTACIÓN <-> TORQUE
        rb.AddRelativeTorque(0,mouseX * (angle * 10) ,0);

        animator.SetFloat("MoveX", horizontal); 
        animator.SetFloat("MoveY", vertical);

        enPiso = Physics.Raycast(refPie.position, Vector3.down, 1.0f, 1<<12);
        animator.SetBool("enPiso", enPiso);

        if (Input.GetButtonDown("Jump") && enPiso)   
        {
            rb.AddForce(new Vector3(0,fuerzaSalto,0), ForceMode.Impulse);
        }

    }
 
}
 