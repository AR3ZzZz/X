using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_8 : MonoBehaviour
{
    int vidasInicio = 120, vidasActual = 120;
    
    int veneno;

    void Start()
    {
        vidasActual = 120;
        vidasInicio = 120;
        veneno = 3;

        vidasActual = vidasActual - (veneno % vidasInicio);
        veneno += 3;
        Debug.Log(vidasActual);
        vidasActual = vidasActual - (veneno % vidasInicio);
        veneno += 3;
        Debug.Log(vidasActual);
        vidasActual = vidasActual - (veneno % vidasInicio);
        veneno += 3;
        Debug.Log(vidasActual);
        vidasActual = vidasActual - (veneno % vidasInicio);
        veneno += 3;
        Debug.Log(vidasActual);
        vidasActual = vidasActual - (veneno % vidasInicio);
        veneno += 3;
        Debug.Log(vidasActual);
    }


    void Update()
    {
        
    }
}
