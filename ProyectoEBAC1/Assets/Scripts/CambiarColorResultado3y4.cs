using UnityEngine;

public class CambiarColorResultado3y4 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        VariablesGlobales.CuboResultado3y4 = true;
        Color c = new Color(250, 250, 250);
        GetComponent<MeshRenderer>().material.color = c;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (VariablesGlobales.EsferaDuplicadaVariable&& VariablesGlobales.EsferaVariable)
        {
            VariablesGlobales.CuboResultado3y4 = true;
            Color c = new Color(250, 250, 250);
            GetComponent<MeshRenderer>().material.color = c;
        }
        else
        {
            VariablesGlobales.CuboResultado3y4 = false;
            Color c = new Color(0, 0, 0);
            GetComponent<MeshRenderer>().material.color = c;

        }
    }
}
