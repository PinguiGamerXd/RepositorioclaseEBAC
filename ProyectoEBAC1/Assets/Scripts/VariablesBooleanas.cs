using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesBooleanas : MonoBehaviour
{

    bool variable1;
    bool variable2;
    bool variable3;
    int valor1 = 5;
    int LimiteInferior = -5;
    int LimiteSuperior = 5;
    enum SeleccionColor
    { 
       rojo,
       verde,
       azul,
       blanco,
       gris,
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        variable1 = true;
        variable2 = false;
        variable3 = false;
        if ((variable1 || variable2) && variable3)
        {
            Debug.Log("La operacion 1 es Verdadero");
        }
        else if ((variable1 || variable2) || variable3)
        {
            if(variable1)
            {
                Debug.Log("La variable 1 es verdadera");
            }
            Debug.Log("La operacion 2 es Verdadero");
        }
        else if ((variable3 && variable2) || variable1)
        {
            Debug.Log("La operacion 3 es Verdadero");
        }

        valor1 = Random.Range(LimiteInferior, LimiteSuperior);
        Debug.Log(valor1);
        //if (valor1 >= 0)
        //{
        //    Debug.Log("El valor es positivo");
        //}
        //else
        //{
        //    Debug.Log("El valor es negativo");
        //}

        string resultado = (valor1 >= 0) ? "El valor es positivo" : "El valor es Negativo";
        Debug.Log(resultado);

        //switch (valor1)
        //{
        //    case(int) SeleccionColor.rojo:
        //        Debug.Log("El color seleccionado es el rojo");
        //        break;
        //    case (int)SeleccionColor.verde:
        //        Debug.Log("El color seleccionado es el verde");
        //        break;
        //    case (int)SeleccionColor.azul:
        //        Debug.Log("El color seleccionado es el azul");
        //        break;
        //    case (int)SeleccionColor.blanco:
        //        Debug.Log("El color seleccionado es el blanco");
        //        break;
        //    case (int)SeleccionColor.gris:
        //        Debug.Log("El color seleccionado es el gris");
        //        break;
        //    default:
        //        Debug.Log("Ese no es un color valido");
        //        break;
        //}

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
