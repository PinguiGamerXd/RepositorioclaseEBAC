using UnityEngine;

public class EjerciciosModulo8Parte2 : MonoBehaviour
{
    int MiPrimerEntero = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string ValorNumericoMiles1 = "125876";
        string ValorNumericoMiles2 = "4091";
        int Numero1, Numero2;

        if (int.TryParse(ValorNumericoMiles1, out Numero1) && int.TryParse(ValorNumericoMiles2, out Numero2))
        {
            int Suma = Numero1 + Numero2;
            Debug.Log($"La suma de los Strings es: {Suma}");
        }
        else
        {
            Debug.Log("Error al convertir los valores.");
        }


        string Oracion = "Hola soy Marco";
        string ResultadoOracion = "";

        for (int i = 0; i < Oracion.Length; i++)
        {
            if (i % 2 == 0)
            {
                ResultadoOracion += Oracion[i];
            }
        }

        Debug.Log("Caracteres en índices pares: " + ResultadoOracion);


        string OracionPorRecortar = "Hola amigos programadores";
        string OracionRecortada = OracionPorRecortar.Substring(5);
        Debug.Log(OracionRecortada);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        MiPrimerEntero += 1;
        Debug.Log(MiPrimerEntero);

        if (MiPrimerEntero % 2 == 0)
        {
            Debug.Log("El Numero " + MiPrimerEntero + " es par");
            Color c = new Color(0, 0, 0);
            GetComponent<MeshRenderer>().material.color = c;
        }
        else
        {
            Debug.Log("El Numero " + MiPrimerEntero + " es impar");
            Color c = new Color(255, 255, 255);
            GetComponent<MeshRenderer>().material.color = c;
        }
    }
}
