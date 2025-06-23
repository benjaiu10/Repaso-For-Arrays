using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepasoFor : MonoBehaviour
{
    // Variables públicas 
    public int primerNumero;
    public int segundoNumero;

    // Start is called before the first frame update
    void Start()
    {
        //ESCRIBIR LOS ENTEROS DESDE 0 HASTA EL 4
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(i);
        }
        //ESCRIBIR LOS ENTEROS MULTIPLOS DE 3 ENTRE 6 Y 30 INCLUSIVE
        for (int i = 6; i <= 30; i += 3)
        {
            Debug.Log(i);
        }
        //ESCRIBIR LOS ENTEROS DESDE 0 HASTA 50 EXCEPTO LOS MULTIPLOS DE 7
        for (int i = 0; i <= 50; i++)
        {
            if (i % 7 != 0)
            {
                Debug.Log(i);
            }
        }

       //ESCRIBIR DOS ENTEROS INGRESADOS POR INSPECOTR
        for (int i = primerNumero + 1; i < segundoNumero; i++)
        {
            Debug.Log(i);
        }

        //ESCRIBIR LOS ENTEROS ENTRE 100 Y 0 DE MANERA DESCENDENTE (INCLUSIVE)
        for (int i = 100; i >= 0; i--)
        {
            Debug.Log(i);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
