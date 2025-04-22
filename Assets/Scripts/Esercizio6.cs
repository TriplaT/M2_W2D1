using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio6 : MonoBehaviour
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
            Stampa2Successivi();
        }
    }

    public void Stampa2Successivi()
    {
        int primoSuccessivo = Partenza + 1;
        int secondoSuccessivo = Partenza + 2;

        Debug.Log("Il primo successivo è: " + primoSuccessivo);
        Debug.Log("Il secondo successivo è: " + secondoSuccessivo);
    }
}
