using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_10 : MonoBehaviour
{
    [SerializeField] int numeroMayor;
    [SerializeField] int numeroMenor;
    int contador;
    void Start()
    {
        for (contador = numeroMenor; contador <= numeroMayor; contador ++)
        {
            Debug.Log("Numero " + contador);

            if (contador % 2 == 0)
            {
                Debug.Log("Numero par");
            }
            else
            {
                Debug.Log("Numero impar");
            }

            if (contador < 0)
            {
                Debug.Log("Numero negativo");
            }
            else
            {
                Debug.Log("Numero positivo");
            }

            
        }

    }

   
}
