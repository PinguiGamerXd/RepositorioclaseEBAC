using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UIElements;

public class CrearCubodesde0 : MonoBehaviour
{

    GameObject objToSpawn;
    Vector3[] vertices = {
          new Vector3 (0,0,0),  //Vertice 0
          new Vector3 (1,0,0),  //Vertice 1
          new Vector3 (1,1,0),  //Vertice 2
          new Vector3 (0,1,0),  //Vertice 3
          new Vector3 (0,1,1),  //Vertice 4
          new Vector3 (1,1,1),  //Vertice 5
          new Vector3 (1,0,1),  //Vertice 6
          new Vector3 (0,0,1),  //Vertice 7
        };

    int[] triangulos = {
          0, 2, 1, //Cara 1
          0, 3, 2,
          2, 3, 4, //Cara 2
          2, 4, 5,
          1, 2, 5, //Cara 3
          1, 5, 6,
          0, 7, 4, //Cara 4
          0, 4, 3,
          5, 4, 7, //Cara 5
          5, 7, 6,
          0, 6, 7, //Cara 6
          0, 1, 6,
        };

// Start is called once before the first execution of Update after the MonoBehaviour is created
void Awake()
    {
        objToSpawn = new GameObject("Nuestro Primer Cubo");
        objToSpawn.AddComponent<MeshFilter>();
        var meshFilter = objToSpawn.GetComponent<MeshFilter>().mesh;
        meshFilter.Clear();
        meshFilter.vertices = vertices;
        meshFilter.triangles = triangulos;
        meshFilter.Optimize();
        meshFilter.RecalculateNormals();
        objToSpawn.AddComponent<BoxCollider>();
        var boxCollider = objToSpawn.GetComponent<BoxCollider>();
        boxCollider.center = new Vector3(0.5f, 0.5f, 0.5f);
        objToSpawn.AddComponent<MeshRenderer>();
        var meshRendererMaterial = objToSpawn.GetComponent<MeshRenderer>().material;
        meshRendererMaterial.color = Color.white;
        objToSpawn.transform.position = Vector3.one;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
