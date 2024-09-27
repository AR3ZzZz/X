using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_3 : MonoBehaviour
{
    int vidas = 3;
    float exp = 5f;

    float resultadoMultiplicacion, resultadoDivision, resultadoPorcentaje, vidasMultiplicacion, expMultiplicacion;

    void Start()
    {
        resultadoMultiplicacion = vidas * exp;
        Debug.Log(resultadoMultiplicacion);

        resultadoDivision = vidas / exp;
        Debug.Log(resultadoDivision);

        resultadoPorcentaje = vidas % exp;
        Debug.Log(resultadoPorcentaje);

        vidasMultiplicacion = vidas * 2;
        Debug.Log(vidasMultiplicacion);

        expMultiplicacion = exp * 3;
        Debug.Log(expMultiplicacion);
    }


    void Update()
    {
        
    }
}
