using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_3 : MonoBehaviour
{
    int numeros = 100;
    void Start()
    {
        while (numeros > 0) 
        {
            Debug.Log("numero " + numeros);
            numeros--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
