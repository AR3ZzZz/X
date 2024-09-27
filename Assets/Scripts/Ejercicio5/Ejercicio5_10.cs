using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_10 : MonoBehaviour
{
    [SerializeField] int temperatura;

    void Start()
    {
        if (temperatura <= 10)
        {
            Debug.Log("Frio");
        }
        else if (temperatura > 10 && temperatura <= 20) 
        {
            Debug.Log("Nublado");
        }
        else if (temperatura > 20 && temperatura <= 30)
        {
            Debug.Log("Caluroso");
        }
        else if(temperatura > 30)
        {
            Debug.Log("Tropical");
        }

    }

   
}
