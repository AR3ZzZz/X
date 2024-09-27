using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_6 : MonoBehaviour
{
    [SerializeField] int numeros;
    int contador;

    void Start()
    {
        contador = numeros;
        while (contador >= -numeros)
        {
            Debug.Log("numero " + contador);
            contador--;
        }

        for (contador = numeros; contador >= -numeros; contador--)
        {
            Debug.Log("numero " + contador);
        }
    }
}
