using UnityEngine;

public class CambiarColorEsferaDuplicada : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        VariablesGlobales.EsferaDuplicadaVariable = true;
        Color c = new Color(250, 250, 250);
        GetComponent<MeshRenderer>().material.color = c;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (VariablesGlobales.CapsulaVariable || VariablesGlobales.CuboVariable)
        {
            VariablesGlobales.EsferaDuplicadaVariable = true;
            Color c = new Color(250, 250, 250);
            GetComponent<MeshRenderer>().material.color = c;
        }
        else
        {
            VariablesGlobales.EsferaDuplicadaVariable = false;
            Color c = new Color(0, 0, 0);
            GetComponent<MeshRenderer>().material.color = c;

        }
    }
}
