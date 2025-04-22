using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio5 : MonoBehaviour
{
    public int numero;
    // Start is called before the first frame update
    void Start()
    {
        numero = Random.Range(1, 21);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.frameCount == 1)
        {
            string pariDispari = (numero % 2 == 0) ? "pari" : "dispari";
            string maggioreDiDieci = (numero > 10) ? "ed è maggiore di 10." : "ed è minore o uguale a 10.";
            Debug.Log($"Il numero {numero} è {pariDispari} {maggioreDiDieci}");
        }
    }
}
