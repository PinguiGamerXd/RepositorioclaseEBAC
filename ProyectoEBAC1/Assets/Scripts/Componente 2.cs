using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Componente2 : MonoBehaviour
{
    private void Awake()
    {
        
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(Componente1.miObjeto.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
