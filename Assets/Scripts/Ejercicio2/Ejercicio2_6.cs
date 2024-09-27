using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_6 : MonoBehaviour
{
    int puntos1, puntos2, puntos3;
    float mediaPuntos;

    void Start()
    {
        puntos1 = 3;
        Debug.Log(puntos1);
        puntos2 = 6;
        Debug.Log(puntos2);
        puntos3 = 8;
        Debug.Log(puntos3);

        mediaPuntos = (puntos1 + puntos2 + puntos3)/3f;
        Debug.Log (mediaPuntos);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
