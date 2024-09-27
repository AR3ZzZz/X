using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_7 : MonoBehaviour
{
    [SerializeField] int numero1;
    [SerializeField] int numero2;
    [SerializeField] int numero3;

    void Start()
    {
        //Si empatan se considera que van ultimos

        //Posicion Nro1
        if (numero1 > numero2 && numero1 > numero3)
        {
            Debug.Log("Numero1 va primero");
        }
        else if (numero1 > numero2 || numero1 > numero3)
        {
            Debug.Log("Numero1 va segundo");
        }
        else  
        {
            Debug.Log("Numero1 va ultimo");
        } 

        //Posicion Nro2
        if (numero2 > numero1 && numero2 > numero3)
        {
            Debug.Log("Numero2 va primero");
        }
        else if (numero2 > numero1 || numero2 > numero3)
        {
            Debug.Log("Numero2 va segundo");
        }
        else
        {
            Debug.Log("Numero2 va ultimo");
        }

        //Posicion Nro3
        if (numero3 > numero1 && numero3 > numero2)
        {
            Debug.Log("Numero3 va primero");
        }
        else if (numero3 > numero1 || numero3 > numero2)
        {
            Debug.Log("Numero3 va segundo");
        }
        else
        {
            Debug.Log("Numero3 va ultimo");
        }
    }

  
}
