using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarColorCubo : MonoBehaviour
{
    public GameObject CuboPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Color c = new Color(Random.value, Random.value, Random.value);
        CuboPrefab.GetComponent<MeshRenderer>().material.color = c;
    }
}
