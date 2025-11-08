using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class Esercizio_3 : MonoBehaviour
{
    // Crea una variabile NumInt in Inspecotor
    [SerializeField] int NumInt = 30;

    // Start is called before the first frame update
    void Start()
    // Iterare i numeri da 1 a NumInt
    {
        for (int i = 1; i <= NumInt; i++) // i <= o < NumInt ??
        {
            // Verifica del resto a 0 dividendo per 3 e 5
            // Se i e' divisibile per 3 e 5 stampa "FizzBuzz"
            // Se i e' divisibile per 3 stampa "Fizz"
            // Se i e' divisibile per 5 stampa "Buzz"
                                                       // Impostare la condizione + "rara" prima
            if (i % 3 == 0 && i % 5 == 0)              // && Operatore di verifica True=True
            {
                Debug.Log( i + " FizzBuzz");           // " FizzBuzz" lo spazio vuoto prima funziona
            }
            else if (i % 3 == 0)
            {
                Debug.Log( i+ " Fizz");
            }
            else if (i % 5 == 0)
            {
                Debug.Log( i+ " Buzz");
            }
                                                       // Se i e' divisibile per entrambi stampa "FizzBuzz"
                                                       // Se i non e' divisibile stampa NumInt
            else
            {
                Debug.Log(i);
            }
        }

    }
}