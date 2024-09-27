using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_12 : MonoBehaviour
{
    [SerializeField] int numero1;
    [SerializeField] int numero2;
    int resultado;
    int contador;
    
    void Start()
    {
        SumarTodosLosNumeros(numero1 , numero2);
    }

    int SumarTodosLosNumeros(int numero1, int numero2)
    {
        for (contador = numero1; contador < numero2; contador++)
        {
            
        }


        return contador + numero2;
    }

    
}
