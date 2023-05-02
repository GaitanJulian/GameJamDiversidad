using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUB : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private TextMeshProUGUI puntos;
    // Start is called before the first frame update
    private void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }


    // Update is called once per frame
    void Update()
    {
        puntos.text = "Points: " + gameManager.PuntosTotales;
    }
}
