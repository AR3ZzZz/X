using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Personaje personaje1;
    [SerializeField] Personaje personaje2;
    bool yaEjecutado;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PrepararPersonaje();
        }
    }

    void PrepararPersonaje()
    {
        if (yaEjecutado == false)
        {
            
            personaje1.Vida = 100;
            personaje2.Vida = 1000;

            personaje1.Exp = 5000;
            personaje2.Exp = 50000;

            personaje1.Nombre = "Raul";
            personaje2.Nombre = "Ovalle";

            float resultado1 = personaje1.CalcularNivel(personaje1.Exp);
            float resultado2 = personaje2.CalcularNivel(personaje2.Exp);

            Debug.Log(resultado1);
            Debug.Log(resultado2);

            yaEjecutado = true ;
        }
        else  
        {
            Debug.Log("No puedes volver a preparar personajes");
                
        }
    }
}
