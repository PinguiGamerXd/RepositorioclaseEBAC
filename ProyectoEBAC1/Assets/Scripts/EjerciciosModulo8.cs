using UnityEngine;

public class EjerciciosModulo8Parte1 : MonoBehaviour
{
    int MiPrimerEntero = 1;
    float MiPrimerFloat = 1;
    private Renderer miRenderer;
    private string colorActual;
    private string[] colores = { "rojo", "verde", "azul", "amarillo", "blanco", "negro" };
    private int indiceColor = 0;
    private float tiempoCambio = 0.5f; 
    private float temporizador = 0f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float MiPrimerFloatParaSumar = 5.5f;
        float MiSegundoFloatParaSumar = 3.5f;
        float resultadoSuma = MiPrimerFloatParaSumar + MiSegundoFloatParaSumar;
        uint MiByteConSigno = (uint)resultadoSuma;
        Debug.Log("Resultado suma de Floats " + MiByteConSigno);

        miRenderer = GetComponent<Renderer>();
        colorActual = colores[0];

        float Precision4Numeros = 1.2345f;
        string Nums = Precision4Numeros.ToString();
        Debug.Log(Nums);

        string MiNombreCompleto = "Marco Guerrero Portillo";
        string MiNombre = MiNombreCompleto.Substring(0, 5);
        string MisApellidos = MiNombreCompleto.Substring(6);
        string MiPrimerApellido = MisApellidos.Substring(0, 8);
        string MiSegundoApellido = MisApellidos.Substring(8);
        Debug.Log(MiNombre);
        Debug.Log(MiPrimerApellido);
        Debug.Log(MiSegundoApellido);


    }

    // Update is called once per frame
    void Update()
    {

        MiPrimerEntero += 1;
        Debug.Log(MiPrimerEntero);

        temporizador += Time.deltaTime;

        if (temporizador >= tiempoCambio)
        {
            
            indiceColor = (indiceColor + 1) % colores.Length;
            colorActual = colores[indiceColor];
            temporizador = 0f;
        }

        CambiarColor(colorActual);
        void CambiarColor(string color)
        {
            switch (color)
            {
                case "rojo":
                    miRenderer.material.color = Color.red;
                    break;
                case "verde":
                    miRenderer.material.color = Color.green;
                    break;
                case "azul":
                    miRenderer.material.color = Color.blue;
                    break;
                case "amarillo":
                    miRenderer.material.color = Color.yellow;
                    break;
                case "blanco":
                    miRenderer.material.color = Color.white;
                    break;
                case "negro":
                    miRenderer.material.color = Color.black;
                    break;
                default:
                    miRenderer.material.color = Color.gray;
                    break;
            }
        }
    }
        void FixedUpdate()
    {
        MiPrimerFloat *= 2;
        Debug.Log(MiPrimerFloat);

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
