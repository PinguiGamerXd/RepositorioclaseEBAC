using System.Collections;
using System.Collections.Generic;
using UnityEngine;



    public class CambiarColorCubo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        VariablesGlobales.CuboVariable = true;
        Debug.Log(VariablesGlobales.CuboVariable);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Color c = new Color(Random.value, Random.value, Random.value);
        //CuboPrefab.GetComponent<MeshRenderer>().material.color = c;
        if (VariablesGlobales.CuboVariable == true)
        {
            Color c = new Color(0, 0, 0);
            GetComponent<MeshRenderer>().material.color = c;
            VariablesGlobales.CuboVariable = false;
            Debug.Log(VariablesGlobales.CuboVariable);
        }
        else
        {
            Color c = new Color(255, 255, 255);
            GetComponent<MeshRenderer>().material.color = c;
            VariablesGlobales.CuboVariable = true;
            Debug.Log(VariablesGlobales.CuboVariable);
        }
    }
}
