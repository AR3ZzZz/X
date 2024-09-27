using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_2 : MonoBehaviour
{



    void Start()
    {
        Debug.Log(ContruirNombre("Raul Andre ", "Ovalle ", "Mejias ", 20));
    }


    void Update()
    {
        
    }

    string ContruirNombre(string nombre, string apellido1, string apellido2,int edad)
    {
        string nombreCompleto = (nombre + apellido1 + apellido2 + edad);

        return nombreCompleto ;
    }
}
