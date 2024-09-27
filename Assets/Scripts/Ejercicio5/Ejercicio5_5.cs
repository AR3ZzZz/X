using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_5 : MonoBehaviour
{
    [SerializeField] int lvl;
    void Start()
    {
        if (lvl % 2 == 0)  
        {
            Debug.Log("Nivel es par");
        }
        else
        {
            Debug.Log("Nivel es impar");
        }

    }


}
