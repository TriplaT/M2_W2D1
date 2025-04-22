using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio2 : MonoBehaviour
{
    int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World");
        Debug.Log("Tutto cio che viene eseguito nello start verrà eseguito prima del primo frame di esecuzione. \n" +
                    "Oltretutto viene eseguito 1 sola volta.");
    }

    // Update is called once per frame
    void Update()
    {
        counter++;
        Debug.Log("Hello World Numero: " + counter);
        Debug.Log("nel metodo Update il codice viene eseguito ad ogni frame.");
    }
}
