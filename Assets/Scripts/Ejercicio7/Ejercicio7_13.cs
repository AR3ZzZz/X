using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_13 : MonoBehaviour
{
    [SerializeField] int numero;
    int contador;
    bool resultado;
    void Start()
    {
       resultado = NumeroPrimo(numero);
        Debug.Log("Numero primo = " + resultado);
    }

    bool NumeroPrimo(int numero)
    {
        for (contador = numero - 1; contador >= 2; contador--)
        {
            Debug.Log(contador);
            if (numero % contador == 0)
            {
                return false;
            }
            
        }
        return true;
    }

}
