using System;
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
        //UpdateGameState(GameState.MainMenu);
        puntosTotales = 0;
    }
    /*
    public enum GameState
    {
        MainMenu,
        GameRun,
        Lose,
    }

    public void UpdateGameState(GameState newState)
    {
        switch (newState)
        {
            case GameState.MainMenu:
                break;
            case GameState.GameRun:
                break;
            case GameState.Lose:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(newState), newState, null);
        }
    }
    */
    public void SumarPuntos(int puntosASumar)
    {
        puntosTotales += puntosASumar;

        // Raise the event to notify subscribers that the points have been updated
        OnPointsUpdate?.Invoke();
    }


}
