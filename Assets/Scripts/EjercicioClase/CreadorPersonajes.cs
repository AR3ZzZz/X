using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreadorPersonajes : MonoBehaviour
{
    [SerializeField]
    Personaje link;
    private void Start()
    {
        link.Vida = 10;
    }
    
}
