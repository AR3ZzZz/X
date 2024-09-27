using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_5 : MonoBehaviour
{

    int radio, altura, lado, ba;
    double circulo, triangulo, cuadrado;

    void Start()
    {
        radio = 6;
        altura = 2;
        lado = 9;
        ba = 5;
        AreaCirculo(radio);
        AreaTriangulo(ba, altura);
        AreaCuadrado(lado);

        Debug.Log(AreaCirculo(radio));
        Debug.Log(AreaTriangulo(ba, altura));
        Debug.Log(AreaCuadrado(lado));

        circulo=AreaCirculo(radio);
        triangulo=AreaTriangulo(ba, altura);
        cuadrado=AreaCuadrado(lado);


        string conversion = Convertir(circulo, "Euro");
        Debug.Log(conversion);
       
        conversion = Convertir(triangulo, "Euro");
        Debug.Log(conversion);
        
        conversion = Convertir(cuadrado, "Euro");
        Debug.Log(conversion);

    }


    void Update()
    {
        
    }
    double AreaCirculo(int radio)
    {
        double area = (radio * radio) * Math.PI;
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
    string Convertir(double cantidad, string moneda)
    {
        string resultado = "";
        //EURO 1 == DOLAR 1.11

        if (moneda == "Euro")
        {
            cantidad = cantidad * 1.11f;
            resultado = cantidad + " Dolares";

        }
        else if (moneda == "Dolar")
        {
            cantidad = cantidad / 1.11f;
            resultado = cantidad + " Euros";

        }

        return resultado;

    }
}
