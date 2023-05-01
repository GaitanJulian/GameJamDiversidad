using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public int coinValue = 1;
    public GameManager gameManager;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // A�adir el valor de la mondeda
            gameManager.SumarPuntos(coinValue);
            transform.position = new Vector3(-1.8f,-2f,0);
        }


    }
}
