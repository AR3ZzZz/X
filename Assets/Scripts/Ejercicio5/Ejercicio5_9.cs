using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_9 : MonoBehaviour
{
    [SerializeField] int tipo;
    void Start()
    {
        if (tipo == 1)
        {
            Debug.Log("Danho 350 y Vida 650");
        }
        else if (tipo == 2)
        {
            Debug.Log("Danho 300 y Vida 550");
        }
        else if (tipo == 3)
        {
            Debug.Log("Danho 300 y Vida 500");
        }
        else if (tipo == 4)
        {
            Debug.Log("Danho 310 y Vida 460");
        }
        else if (tipo == 5)
        {
            Debug.Log("Danho 280 y Vida 490");
        }
        else if (tipo == 6)
        {
            Debug.Log("Danho 360 y Vida 520");
        }
        else 
        {
            Debug.Log("No existe ese tipo");
        }
    }

    
}
