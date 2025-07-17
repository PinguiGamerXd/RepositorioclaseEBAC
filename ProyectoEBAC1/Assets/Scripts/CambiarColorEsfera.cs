using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarColorEsfera : MonoBehaviour
{
    public GameObject EsferaPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Color c = new Color(Random.value, Random.value, Random.value);
        EsferaPrefab.GetComponent<MeshRenderer>().material.color = c;
    }
}
