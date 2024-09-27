using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_7 : MonoBehaviour
{
    [SerializeField] int numeroMayor;
    [SerializeField] int numeroMenor;
    int contador;
    void Start()
    {
        for ( contador = numeroMenor; contador <= numeroMayor; contador++)
        {
            Debug.Log("Numero " +  contador);
        }
    }

   
}
