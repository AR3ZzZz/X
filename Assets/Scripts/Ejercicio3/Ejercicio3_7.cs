using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_7 : MonoBehaviour
{
    [SerializeField]
    int baseTriangulo, alturaTriangulo;

    int areaTriangulo;

    //Triangulo: (base * altura) / 2 
    void Start()
    {
        areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;
        Debug.Log(areaTriangulo);
    }

    void Update()
    {
        
    }
}
