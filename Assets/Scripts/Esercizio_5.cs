using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio_5 : MonoBehaviour
{
    // Variabili NumberToFind, ArraySize e numnerOffsett
    [SerializeField] private int numberToFind;
    private int arraySize = 30;
    [SerializeField] private int numberOffsett;
    // Creare un array con dimensione di ArraySize
    // Start is called before the first frame update
    void Start()
    // Creare Array dimensione= ArraySize(30) con numeri da 0 a 30
    {
        int[] Array = new int[arraySize];
        // !! Dichiarare gli offset PRIMA !!
        // Partendo da numberOffsett calcolare minValue e maxValue
        int minValue = numberToFind - numberOffsett;
        int maxValue = numberToFind + numberOffsett;
        // Se i limiti vengono calcolati successivemente alla creazione
        // dell' Array questo non verrà generato con i valori corretti!!

        for (int i = 0; i < arraySize; i++)
        {
            // Genera numeri tra minValue e maxValue
            Array[i] = Random.Range(minValue, maxValue +1); // Bisogna aggiungere +1 a maxValue per includerlo
            if (Array[i] == numberToFind) // Confronta con numberToFind Stampa "Found" se uguale
                Debug.Log("Found");
            else // Altrimenti "Not Found"
                Debug.Log("Not Found");
        }
        Debug.Log("Iteration Finished");
    }

}