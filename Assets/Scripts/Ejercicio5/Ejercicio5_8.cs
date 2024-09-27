using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_8 : MonoBehaviour
{
    [SerializeField] int H;
    [SerializeField] int M;
    [SerializeField] int S;
    void Start()
    {
        if (H >= 0 && H <=24)
        {
            if(M >= 0 && M <= 60)
            {
                if (S >= 0 && S <= 60)
                {
                    Debug.Log("Son las " + H + ":" + M + ":" + S);
                }
            }
        }
    }

   
}
