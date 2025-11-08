using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esercizio_1 : MonoBehaviour

{
    // Start is called before the first frame update
    // Due variabili intere in Inspector "index" e "num"
    // Loop in While incramenta "num" di 1 e diminuisce "index" di 1 fino a index 0
    [SerializeField] public int index;
    [SerializeField] public int num;
    void Start()
    {
        while (index > 0)
        {   
            num = num + 1;
            Debug.Log(num);
            index = index - 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
