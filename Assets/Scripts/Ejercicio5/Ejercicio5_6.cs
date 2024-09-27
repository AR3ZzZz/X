using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_6 : MonoBehaviour
{
    [SerializeField] int lvl;
    int resultado;
    
    void Start()
    {
        resultado = lvl % 10;

        if ( resultado == 0)
        {
            Debug.Log(resultado);
            Debug.Log("Multiplo de 10");

        }
    }

   
}
