using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio4 : MonoBehaviour
{
    public int numero1;
    public int numero2;
    public int numero3;
    public int numero4;
    // Start is called before the first frame update
    void Start()
    {
        numero1 = Random.Range(1, 101);
        numero2 = Random.Range(1, 101);
        numero3 = Random.Range(1, 101);
        numero4 = Random.Range(1, 101);
    }

    void CalcolaEStampa()
    {
        int somma = numero1 + numero2 + numero3 + numero4;
        int prodotto = numero1 * numero2 * numero3 * numero4;
        float media = somma / 4f;

        Debug.Log($"Numeri: {numero1}, {numero2}, {numero3}, {numero4}");
        Debug.Log("Somma: " + somma);
        Debug.Log("Prodotto: " + prodotto);
        Debug.Log("Media: " + media);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.frameCount == 1)
        {
            CalcolaEStampa();
        }
    }
}
