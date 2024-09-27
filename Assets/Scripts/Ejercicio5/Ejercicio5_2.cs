using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_2 : MonoBehaviour
{
    [SerializeField] int numero1;
    [SerializeField] int numero2;
    int numero3 = 3;

    void Start()
    {
        if (numero1 < numero3)
        {
            Debug.Log("Numero1 es menor que " + numero3);
        }
        if (numero2 < numero3)
        {
            Debug.Log("Numero2 es menor que " + numero3);
        }
    }

}
