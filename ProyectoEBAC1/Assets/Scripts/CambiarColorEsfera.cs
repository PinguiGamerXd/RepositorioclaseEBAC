using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.Burst;
using UnityEngine;

public class CambiarColorEsfera : MonoBehaviour
{
    public GameObject EsferaPrefab;
   
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        VariablesGlobales.EsferaVariable = true;
        Color c = new Color(250, 250, 250);
        EsferaPrefab.GetComponent<MeshRenderer>().material.color = c;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
       if(VariablesGlobales.CapsulaVariable && VariablesGlobales.CuboVariable)
        {
            VariablesGlobales.EsferaVariable = true;
            Color c = new Color(250, 250, 250);
            GetComponent<MeshRenderer>().material.color = c;
        }
        else
        {
            VariablesGlobales.EsferaVariable = false;
            Color c = new Color(0, 0, 0);
            GetComponent<MeshRenderer>().material.color = c;

        }

    }
}
