using Mono.Cecil.Cil;
using UnityEngine;

public class EjerciciosCiclosYArreglos : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] PrimerArregloUnidemensional = new int[5];
        int[] SegundoArregloUnidemensional = new int[5];
        for (int i = 0; i < 5; i++)
        {
            PrimerArregloUnidemensional[i] = Random.Range(0, 9);
            Debug.Log($"Numeros del Primer Arreglo: {PrimerArregloUnidemensional[i]}");
    }
        for (int i = 0; i< 5; i++)
        {
            SegundoArregloUnidemensional[i] = Random.Range(0, 9);
            Debug.Log($"Numeros del Segundo Arreglo: {SegundoArregloUnidemensional[i]}");
        }
        int[] TercerArregloUnidemensional = new int[5];
        for (int i = 0; i < 5; i++)
        {
            TercerArregloUnidemensional[i] = PrimerArregloUnidemensional[i] + SegundoArregloUnidemensional[i];
            Debug.Log($"Suma de los Arreglos: {TercerArregloUnidemensional[i]}");
        }


        string[] MiOracionDescompuesta = new string[3] { "Hola", "soy", "Marco" };
        string OracionCompleta = "";
        foreach(string palabra in MiOracionDescompuesta)
        {
            OracionCompleta += palabra + " ";
        }
        Debug.Log(OracionCompleta);


        int[,] MiMatriz = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
        int[] MiVector = new int[3] { 7, 8, 9 };
        int filas = MiMatriz.GetLength(0);
        int columnas = MiMatriz.GetLength(1);
        int []resultado = new int[filas];

        for (int i = 0; i < filas; i++)
        {
            int suma = 0;
            for (int j = 0; j < columnas;  j++)
            {
                suma += MiMatriz[i, j] * MiVector[j];
            }
            resultado[i] = suma;
        }
        for (int i = 0; i < resultado.Length; i++)
        {
            Debug.Log(resultado[i]);
        }
    }



    


    // Update is called once per frame
    void Update()
    {
        
    }
}
