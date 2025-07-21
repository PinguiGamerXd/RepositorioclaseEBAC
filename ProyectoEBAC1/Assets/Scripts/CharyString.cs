using UnityEngine;

public class CharyString : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        char c = '6';
        int ValorEntero = 0; /*int.Parse(c.ToString());*/ /*(int)char.GetNumericValue(c)+'5';*/
        if (!int.TryParse(c.ToString(), out ValorEntero))
        {
            Debug.LogError("Eso no es un tipo de dato valido.");
        }

        Debug.Log(ValorEntero);

        char MiCaracter;
        string MiString = "Hola desde EBAC";
        string MiSegundoString = MiString.ToUpper();/*Replace('e', 'E');*/
        string MiTercerString = MiString + " " + MiSegundoString;
        string EjemploEscape = "C:\\Users\\Diego\\Documentos";
        string MiNombre = "Marco";
        string MisApellidos = "Guerrero Portillo";
        string PrimerApellido = MisApellidos.Substring(0, 8);
        string SalidaSuma = "Mi nombre es: " + MiNombre + " Y mis Apellidos son " + MisApellidos;
        string Salida = $"Mi nombre es: {MiNombre} Y mis Apellidos son {MisApellidos}";
        int Longitud = MiString.Length;
        Debug.Log(Longitud);
        Debug.Log(Salida);
        Debug.Log(PrimerApellido);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
