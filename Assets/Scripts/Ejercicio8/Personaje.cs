using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
   [SerializeField]private int vida;
   [SerializeField]private string nombre;
   [SerializeField]private int exp;

    public int Exp { get => exp; set => exp = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public int Vida { get => vida; set => vida = value; }

    void Start()
    {
        
    }

    void Update()
    {

    }

   public float CalcularNivel(int exp) 
   {
        int lvl = exp / 1000;
        return lvl;
   }
}
