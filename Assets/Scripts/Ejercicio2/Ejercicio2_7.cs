using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_7 : MonoBehaviour
{
    int oroPorSeg = 7;
    int tiempoEnHoras = 4;
    int oroFarmeado;

    void Start()
    {
        oroFarmeado = (360*tiempoEnHoras)*oroPorSeg;
        Debug.Log(oroFarmeado);
    }

    void Update()
    {
        
    }
}
