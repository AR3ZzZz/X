using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_1 : MonoBehaviour
{

    int radio, altura, lado, ba;

    void Start()
    {
        radio = 6;
        altura = 2;
        lado = 9;
        ba = 5;
        AreaCirculo(radio);
        AreaTriangulo(ba,altura);
        AreaCuadrado(altura);

        Debug.Log(AreaCirculo(radio));
        Debug.Log(AreaTriangulo(ba,altura));
        Debug.Log(AreaCuadrado(lado));
    }


    void Update()
    {
        
    }

    double AreaCirculo(int radio)
    {
        double area = (radio*radio)*Math.PI;
        return area;
    }
    double AreaTriangulo(int ba, int altura)
    {
        double area = (ba * altura) / 2;
        return area;
    }
    double AreaCuadrado(int lado)
    {
        double area = (lado * lado);
        return area;
    }
}
