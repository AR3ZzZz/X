using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_3 : MonoBehaviour
{
    [SerializeField]
    int numero;


    int numeroPor2, numeroPor3; 
    void Start()
    {
        numeroPor2 = numero * 2;
        Debug.Log(numeroPor2);
        numeroPor3 = numero * 3;
        Debug.Log(numeroPor3);



    }

    void Update()
    {
        
    }
}
