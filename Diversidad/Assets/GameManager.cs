using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int PuntosTotales { get { return puntosTotales; } }
    private int puntosTotales;

    public delegate void PointsUpdateHandler();
    public static event PointsUpdateHandler OnPointsUpdate;

    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        puntosTotales = 0;
    }


    public void SumarPuntos(int puntosASumar)
    {
        puntosTotales += puntosASumar;

        // Raise the event to notify subscribers that the points have been updated
        OnPointsUpdate?.Invoke();
    }


}
