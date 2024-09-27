using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_4 : MonoBehaviour
{


    void Start()
    {
        ConversorVelocidad(20);
        Debug.Log(ConversorVelocidad(20));
    }


    void Update()
    {
        
    }

    float ConversorVelocidad(float KMH)
    {
        float MS = KMH / 3.6f;
        return MS;

    }
}
