using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HOLAMUNDOF2FINAL : MonoBehaviour
{

    int x = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Valor inicial de x:" + x);
        print("Hola Mundo");
        
        Debug.LogWarning("Algo malo paso");
        Debug.LogError("Algo muy malo paso");
    }

    // Update is called once per frame
    void Update()
    {
        //x = x + 1;
        //Debug.Log("Valor actualizado de x: " + x);

        Debug.Log("Hola desde update");

    }
    private void FixedUpdate()
    {
        Debug.LogWarning("Hola desde Fixed Update cada 50 frames");
    }
    private void LateUpdate()
    {
        Debug.Log("Hola desde Late Update");
    }

    private void OnEnable()
    {
        Debug.LogWarning("El objeto ha sido abilitado");
    }

    private void OnDisable()
    {
        Debug.LogWarning("El objeto ha sido deshabilitado");    
    }
}
