using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio7 : MonoBehaviour
{
    public int Partenza;
    // Start is called before the first frame update
    void Start()
    {
        Partenza = Random.Range(1, 101);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.frameCount == 1)
        {
            Stampa2Precedenti();
        }
    }

    public void Stampa2Precedenti()
    {
        int primoPrecedente = Partenza - 1;
        int secondoPrecedente = Partenza - 2;

        Debug.Log("Il primo Precedente è: " + primoPrecedente);
        Debug.Log("Il secondo Precedente è: " + secondoPrecedente);
    }
}
