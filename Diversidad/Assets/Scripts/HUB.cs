using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class HUB : MonoBehaviour
{ 

    [SerializeField] private TextMeshProUGUI puntos;
    [SerializeField] private GameObject panel;
    [SerializeField] private TextMeshProUGUI finalScore;

    // Start is called before the first frame 
    private void Awake()
    {
        GameManager.OnPointsUpdate += UpdatePointsText;
        startUI();
    }

    private void Start()
    {
        PlayerController.OnPlayerDead += loseUI;
    }
    private void UpdatePointsText()
    {
        puntos.text = "Points: " + GameManager.Instance.PuntosTotales;
    }

    //This method avoids memory leaks
    private void OnDestroy()
    {
        GameManager.OnPointsUpdate -= UpdatePointsText;
        PlayerController.OnPlayerDead -= loseUI;


    }

    private void startUI()
    {
        puntos.gameObject.SetActive(true);
        panel.gameObject.SetActive(false);
    }

    private void loseUI()
    {
        puntos.gameObject.SetActive(false);
        finalScore.text += " " + GameManager.Instance.PuntosTotales;
        panel.gameObject.SetActive(true);

    }

}
