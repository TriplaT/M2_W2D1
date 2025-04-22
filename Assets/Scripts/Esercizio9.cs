using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio9 : MonoBehaviour
{
    public int numero1;
    public int numero2;
    // Start is called before the first frame update
    void Start()
    {
        numero1 = Random.Range(1, 101);
        numero2 = Random.Range(1, 101);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.frameCount == 1)
        {
            MinoreTra2();
        }
    }

    void MinoreTra2()
    {
        int minore = (numero1 < numero2) ? numero1 : numero2;
        Debug.Log("Valore1: " + numero1);
        Debug.Log("Valore2: " + numero2);
        Debug.Log("Il minore tra i due è: " + minore);
    }
}
