using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroy : MonoBehaviour
{
    [Tooltip("Tiempo antes de destruir el objeto")]
    public float destructionDelay;
    // Start is called before the first frame update
    void OnEnable() {
        
        //Destroy(gameObject, destructionDelay); // to do: mejorar la destruccion de la bala
        
        Invoke("HideObject", destructionDelay);
    }

    void HideObject()
    {
        gameObject.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}