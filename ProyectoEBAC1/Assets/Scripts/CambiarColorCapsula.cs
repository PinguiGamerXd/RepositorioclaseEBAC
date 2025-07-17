using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarColorCapsula : MonoBehaviour
{
    public GameObject CapsulaPrefab;
    private void Awake()
    {
        Color c = new Color(Random.value, Random.value, Random.value);
        CapsulaPrefab.GetComponent<MeshRenderer>().material.color = c;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
