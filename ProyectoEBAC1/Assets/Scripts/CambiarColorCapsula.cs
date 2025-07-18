using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class VariablesGlobales
{
    public static bool CapsulaVariable = true;
    public static bool CuboVariable = true;
    public static bool EsferaVariable;
    public static bool EsferaDuplicadaVariable = true;
    public static bool CuboResultado3y4 = true;
}
public class CambiarColorCapsula : MonoBehaviour
{
    public GameObject CapsulaPrefab;
    private void Awake()
    {
        Color c = new Color(255, 255, 255);
        CapsulaPrefab.GetComponent<MeshRenderer>().material.color = c;
        VariablesGlobales.CapsulaVariable = true;
        Debug.Log(VariablesGlobales.CapsulaVariable);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (VariablesGlobales.CapsulaVariable == true)
        {
            Color c = new Color(0, 0, 0);
            GetComponent<MeshRenderer>().material.color = c;
            VariablesGlobales.CapsulaVariable = false;
        }
        else
        {
            Color c = new Color(255, 255, 255);
            GetComponent<MeshRenderer>().material.color = c;
            VariablesGlobales.CapsulaVariable = true;
        }
    }
}
