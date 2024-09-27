using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_6 : MonoBehaviour
{
    [SerializeField]
    float velocidadHora;

    // KM/H --> /3,6 --> M/S
    float velocidadSeg;
    void Start()
    {
        velocidadSeg = velocidadHora / 3.6f;
        Debug.Log(velocidadSeg);
    }


    void Update()
    {
        
    }
}
