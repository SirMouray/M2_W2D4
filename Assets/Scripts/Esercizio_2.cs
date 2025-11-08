using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio_2 : MonoBehaviour
{
    // Dichiarare un Array di 4 numeri interi
    // Inserire valori dell' Array0 da inspctor
    [SerializeField] int[] Array0 = new int[4];
    // Dichiarare le variabili da stamapre in console
    int somma = 0;
    int prodotto = 1; // Il prodotto NON puo' essere 0!!!
    // Start is called before the first frame update
    void Start()
    {
     // Inserire valori dell' Array0 da inspctor
        for (int i = 0; i < Array0.Length; i++)
        {
            somma = somma + Array0[i];         // Calcolare la somma dei numeri nell' Array0
            prodotto = prodotto * Array0[i];   // Calcolare il prodotto dei numeri nell' Array0
        }
     // Stampare in Console Somma e Prodotto dei numeri
        Debug.Log("Somma " + somma);
        Debug.Log("Prodotto " + prodotto);
    }
}