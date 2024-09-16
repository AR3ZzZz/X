using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_3 : MonoBehaviour
{


    void Start()
    {
        string conversion = Convertir(44,"Euro");
        Debug.Log(conversion);
    }


    void Update()
    {
        
    }

    string Convertir(float cantidad, string moneda)
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
