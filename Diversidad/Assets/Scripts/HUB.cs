using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUB : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private TextMeshProUGUI puntos;

    // Start is called before the first frame 
    private void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        GameManager.OnPointsUpdate += UpdatePointsText;
    }

    private void UpdatePointsText()
    {
        puntos.text = "Points: " + gameManager.PuntosTotales;
    }

    //This method avoids memory leaks
    private void OnDestroy()
    {
        GameManager.OnPointsUpdate -= UpdatePointsText;
    }

}
