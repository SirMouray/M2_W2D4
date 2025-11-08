using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio_4 : MonoBehaviour
{
    [SerializeField] private int startNumber;
    [SerializeField] private int Amount;
    // Variabili in inspector startNumber e Amount
    // Start is called before the first frame update
    void Start()
    {
        while (Amount >= 0) // Primo ciclo infinito per un ; di troppo!! GG
        {
            Debug.Log(startNumber + 1);
            startNumber++;
            Amount--;
        }
    }
    // Stampa in console il numero di partenza + 1 fino Amount
    // Update is called once per frame
    void Update()
    {

    }
}
//for (int i = 0; i < Amount; i++) ;
