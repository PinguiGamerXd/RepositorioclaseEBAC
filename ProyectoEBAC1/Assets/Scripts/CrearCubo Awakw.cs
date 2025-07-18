using UnityEngine;

public class CrearCuboAwakw : MonoBehaviour
{
    public GameObject CuboPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Awake()
    {
        Instantiate(CuboPrefab);
    }
}
