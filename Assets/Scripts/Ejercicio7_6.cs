using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_6 : MonoBehaviour
{
    [SerializeField] int numeros;

    void Start()
    {
        while (numeros <= -numeros)
        {
            Debug.Log("numero " + numeros);
            numeros--;
        }

        for (numeros = 0; numeros < -numeros; numeros--)
        {
            Debug.Log("numero " + numeros);
        }
    }


    void Update()
    {
        
    }
}
