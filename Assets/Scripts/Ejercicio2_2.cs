using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_2 : MonoBehaviour
{
    int vidas =10;
    float exp ;
    char carac;


    float resultadoSuma, resultadoResta;

    void Start()
    {
        vidas = 6;
        Debug.Log(vidas);
        exp = 10f;
        Debug.Log(exp);

        resultadoSuma = vidas + exp;
        Debug.Log(resultadoSuma);

        resultadoResta = exp - vidas;
        Debug.Log(resultadoResta);

    }

    void Update()
    {
        
    }
}
