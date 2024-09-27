using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_5 : MonoBehaviour
{
    [SerializeField]
    int radio;

    double areaCircunferencia, longitudCircunferencia;
    void Start()
    {
        areaCircunferencia = Math.PI*(radio*radio);
        Debug.Log(areaCircunferencia);
        longitudCircunferencia = 2 * Math.PI * radio;
        Debug.Log(longitudCircunferencia);
    }

    void Update()
    {
        
    }
}
