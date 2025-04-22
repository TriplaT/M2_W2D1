using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio10 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Timer avviato.");
    }

    // Update is called once per frame
    void Update()
    {
        float tempo = Time.time;
        int caseId = StampaCase(tempo);
        StampaMessaggio(caseId);
    }

    int StampaCase(float tempo)
    {
        if (tempo < 30f)
            return 0;
        else if (tempo > 60f)
            return 3;
        else if (tempo > 45f)
            return 2;
        else if (tempo > 30f)
            return 1;

        return -1;
    }

    void StampaMessaggio(int caseId)
    {
        switch (caseId)
        {
            case 0:
                Debug.Log("Sono passati meno di 30 secondi");
                break;
            case 1:
                Debug.Log("Sono passati più di 30 secondi");
                break;
            case 2:
                Debug.Log("Sono passati più di 45 secondi");
                break;
            case 3:
                Debug.Log("Sono passati più di 1 minuto");
                break;
        }
    }
}
