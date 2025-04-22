using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio11 : MonoBehaviour
{
    public float votoNumerico;
    private Dictionary<float, string> associazioneVoti = new Dictionary<float, string>()
    {
        {10f, "A+"},
        {9f, "A"},
        {7.8f, "B"},
        {6f, "C"},
        {5f, "E"},
        {0.4f, "F"}
    };

    void Start()
    {
        List<float> keys = new List<float>(associazioneVoti.Keys);
        int randomIndex = Random.Range(0, keys.Count);
        votoNumerico = keys[randomIndex];
    }

    void Update()
    {
        string letterGrade = CalculateLetterGrade(votoNumerico);
        Debug.Log("La lettera corrisponente al voto: " + votoNumerico + " è " + letterGrade);
    }

    private string CalculateLetterGrade(float valutazione)
    {
        List<float> voti = new List<float>(associazioneVoti.Keys);
        voti.Sort((a, b) => b.CompareTo(a));

        foreach (float voto in voti)
        {
            if (valutazione >= voto)
            {
                return associazioneVoti[voto];
            }
        }
        return "F";
    }
}