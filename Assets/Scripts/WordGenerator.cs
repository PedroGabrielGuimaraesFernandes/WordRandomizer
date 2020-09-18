using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class WordGenerator {

    public static string[] words = { "Estranho", "Louco", "Maluco"};
    public static string[] nomes = { "Pedro", "Lucas", "Gabriel", "Tiago", "Amanda", "Rosana", "Juliana", "Ana", "Enzo", "João"};

    public static string GenarateWord()
    {
        return words[(int)Random.Range(0,words.Length)];
    }

    public static string GenarateName()
    {
        int valor1 = (int)Random.Range(0, nomes.Length);
        int valor2 = (int)Random.Range(0, nomes.Length);
        while(valor1 == valor2)
        {
            valor2 = (int)Random.Range(0, nomes.Length);
        }

        return (nomes[valor1] + " " + nomes[valor2]);
    }

}
