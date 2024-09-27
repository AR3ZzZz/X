using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_5 : MonoBehaviour
{
    int vidaPlayer1Inicial = 6, vidaPlayer2Inicial = 9, vidaPlayer3Inicial = 12 , vidaPlayer4Inicial = 15;

    int vidaActual1, vidaActual2, vidaActual3, vidaActual4;
    void Start()
    {
        vidaActual2 = vidaPlayer3Inicial;
        Debug.Log(vidaActual2);
        vidaActual3 = vidaPlayer1Inicial;
        Debug.Log(vidaActual3);
        vidaActual1 = vidaPlayer4Inicial;
        Debug.Log(vidaActual1);
        vidaActual4 = vidaPlayer2Inicial;
        Debug.Log(vidaActual4);
        
    }


    void Update()
    {
        
    }
}
