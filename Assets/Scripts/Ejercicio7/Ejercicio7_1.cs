using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_1 : MonoBehaviour
{

    int numeros = 1;


    void Start()
    {
        while (numeros <= 100) 
        {
            Debug.Log("numero " +  numeros);
            numeros++;
        }

        

    }

    void Update()
    {

    }



}
