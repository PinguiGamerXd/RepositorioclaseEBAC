using UnityEngine;

public class Numeros : MonoBehaviour
{
    sbyte MiByteConSigno = 0;
    byte MiByte = 0;
    short MiShort = 0;
    ushort MiShortSinSigno = 0;
    int MiInt = 0;
    uint MiIntSinSigno = 0;
    long MiLong = long.MaxValue;
    ulong MiLongSinSigno = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MiByteConSigno = -25;
        MiInt = MiByteConSigno;
        Debug.Log("El valor de mi Byte con signo es de " + MiByteConSigno);
        Debug.Log("El valor de mi int es " + MiInt);
        MiByte = 200;
        MiIntSinSigno = (uint)MiByteConSigno;
        Debug.Log("El valor de mi Int sin signo es  " + MiIntSinSigno);

        MiLong = long.MaxValue;
        MiInt = (int)MiLong;
        Debug.Log("El valor de mi Int es " + MiInt);

        int a, b, c;
        float f;
        a = 5;
        b = 10;
        c = a + b;
        Debug.Log(c);
        c = a * b;
        Debug.Log(c);
        c = a - b;
        Debug.Log(c);
        f = a / b;
        Debug.Log(f);
        MiInt = Random.Range(a, b);
        if (MiInt % 2 == 0)
        {
            Debug.Log("El Numero " + MiInt + " es par");
        }
        else 
        {
            Debug.Log("El Numero " + MiInt + " es impar");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
