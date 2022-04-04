//Crear una variable entera que pueda ser modificada desde el Inspector.Suponiendo que
//el primer día de la semana es el Domingo, mostrar el nombre del día correspondiente al
//valor de la variable “dia”. Si el día no está en el rango permitido debe emitir por pantalla el
//mensaje de error "El día ingresado no es válido".
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eje08 : MonoBehaviour
{
    public int numDia;
    // Start is called before the first frame update
    void Start()
    {
        switch (numDia)
        {
            case 1:
                Debug.Log("domingo");
                break;
            case 2:
                Debug.Log("lunes");
                break;
            case 3:
                Debug.Log("martes");
                break;
            case 4:
                Debug.Log("miercoles");
                break;
            case 5:
                Debug.Log("jueves");
                break;
            case 6:
                Debug.Log("viernes");
                break;
            case 7:
                Debug.Log("sabado");
                break;
            default:
                Debug.Log("el dia ingresado no es valido");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
