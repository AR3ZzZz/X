using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_5 : MonoBehaviour
{
    [SerializeField] int numeros;
    int contador = 1;

    void Start()
    {
        while (contador <= numeros)
        {
            Debug.Log("numero " + contador);
            contador++;
        }

        for (contador = 0; contador < numeros; contador++)
        {
            Debug.Log("numero " + (contador + 1));
        }
    }
}
