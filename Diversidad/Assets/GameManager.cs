using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int PuntosTotales { get { return puntosTotales; } }
    private int puntosTotales;


    private void Start()
    {
        puntosTotales = 0;
        Debug.Log("puntosTotales initialized to 0.");
    }


    public void SumarPuntos(int puntosASumar)
    {
        puntosTotales += puntosASumar;
        Debug.Log("Adding " + puntosASumar + " points. Total points: " + puntosTotales);
    }


}
