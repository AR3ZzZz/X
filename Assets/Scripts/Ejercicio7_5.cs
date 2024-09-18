using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_5 : MonoBehaviour
{
    [SerializeField] int numeros;

    void Start()
    {
        while (numeros <= 100)
        {
            Debug.Log("numero " + numeros);
            numeros++;
        }

        for (numeros = 0; numeros < 100; numeros++)
        {
            Debug.Log("numero " + (numeros + 1));
        }
    }

    void Update()
    {
        
    }
}
