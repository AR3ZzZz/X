using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaDeVida : MonoBehaviour
{
    [SerializeField] int vidaInicial;
    float vidaActual;

    public int VidaInicial { get => vidaInicial; set => vidaInicial = value; }

   float RecibirCura(float cantidad)
    {
        if (cantidad > 0)
        {
            vidaActual += cantidad;
        }
        else
        {
            float fallo = -1;
            return fallo;
        }
        return vidaActual;
    }

    float RecibirDanho(float danho) 
    {
        if (danho > 0)
        {
            vidaActual -= danho;
        }
        else
        {
            float fallo = -1;
            return fallo;
        }

        if (vidaActual < 0)
        {
            vidaActual = 0;
        }

        return vidaActual;
    }
}
