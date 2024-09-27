using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_11 : MonoBehaviour
{
    [SerializeField] int numero;
    int resultado;
    void Start()
    {
        for (int i = 0; i <= 10; i++)
        {
            resultado = i * numero;
            Debug.Log("Numero " + resultado);
        }
    }

   
}
