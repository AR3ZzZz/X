using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_4 : MonoBehaviour
{
    [SerializeField] int dividendo;
    [SerializeField] int divisor;
    int resultado;

    void Start()
    {
        if (divisor > 0)
        {
            resultado = dividendo / divisor;
            Debug.Log(resultado);
        }
        else  
        {
            Debug.Log("Dividendo menor que 0");
        } 
    }

   
    
}
