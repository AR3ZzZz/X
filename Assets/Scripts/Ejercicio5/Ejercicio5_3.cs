using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_3 : MonoBehaviour
{
    [SerializeField] int numero1;
    void Start()
    {
        if (numero1 >=0 && numero1 <= 9)
        {
            Debug.Log("El numero esta entre el 0 y el 9");
        }
    }

    
}
