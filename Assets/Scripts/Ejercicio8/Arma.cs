using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    [SerializeField] float danhoMaximo;
    [SerializeField] float danhoMinimo;
    [SerializeField] int CapacidadTotal;
    [SerializeField] bool automatica;
    int municionActual;

 
    void Start()
    {
        municionActual = CapacidadTotal;
    }

    void Update()
    {
        
    }

    //int UtilizarArma()
    //{

    //}


}
