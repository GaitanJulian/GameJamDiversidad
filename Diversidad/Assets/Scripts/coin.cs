using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public int coinValue = 1;

    private void OnTriggerEnter2D(Collider2D collision) { 

        if (collision.gameObject.CompareTag("Player"))
        {
            // A�adir el valor de la mondeda
            SumPoints();
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }

    private void SumPoints()
    {
        GameManager.Instance.SumarPuntos(coinValue);
    }
    
}
