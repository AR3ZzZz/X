using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1_1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("¡Hola Mundo!");
        Debug.Log("¡Este es el primer videojuego de Raul Ovalle");
        Debug.Log("Estoy aprendiendo C#");

    }

    // Update is called once per frame
    void Update()
    {
        /*Este mensaje va a aparecer cada frame ya que
         *esta situado en el update que sucede cada frame*/
        Debug.Log("Ha pasado un frame");
        
    }
}
