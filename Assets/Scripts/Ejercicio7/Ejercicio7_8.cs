using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_8 : MonoBehaviour
{
    [SerializeField] int numeroMayor;
    [SerializeField] int numeroMenor;
    int contador;
    void Start()
    {
        if (numeroMenor % 2 == 0)
        {
            for (contador = numeroMenor; contador <= numeroMayor; contador += 2)
            {
                Debug.Log("Numero " + contador);
            }
        }
        else if (numeroMenor % 2 != 0)
        {
            numeroMenor += 1;
            for (contador = numeroMenor; contador <= numeroMayor; contador += 2)
            {
                Debug.Log("Numero " + contador);
            }
        }
        
    }
}
